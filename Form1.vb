Imports System.IO
Imports System.Text
Public Class Form1
    Dim ir1 As Integer
    Dim ir2 As Integer
    Dim ir3 As Integer
    Dim qtdvar As Integer


    Dim r1() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", ".", ","}
    Dim r1trab() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", ".", ","}

    Dim r2() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", ".", ","}
    Dim r2trab() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", ".", ","}

    Dim r3() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", ".", ","}
    Dim r3trab() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", ".", ","}


    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer


    Private Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)
        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)
        Return string_builder.ToString()
    End Function

    'Private Sub gravaArquivoini(ByVal grupo As String, ByVal campo As String, ByVal dado As String)
    'Dim nome_arquivo_ini As String = nomeArquivoINI()
    '   WritePrivateProfileString(grupo.ToString, campo.ToString, dado.ToString, nome_arquivo_ini)
    'End Sub

    Private Function nomeArquivoINI(ByVal rotor As Integer) As String
        Dim nome_arquivo_ini As String = Application.StartupPath
        Return nome_arquivo_ini & "\rotor" + rotor.ToString + ".ini"
    End Function

    Public Function RemoveAcentos(ByVal texto As String) As String
        Dim charFrom As String = "ŠŒŽšœžŸ¥µÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýÿ"
        Dim charTo As String = "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy"
        For i As Integer = 0 To charFrom.Length - 1
            texto = Replace(texto, charFrom(i), charTo(i))
        Next
        Return texto
    End Function

    Function rekey() 'reverte o codgio para as funçoes necessarias
        Dim key As String = ""

        'aqui vc deve colocar o codgo que valida a key
        If (TextBox1.Text.Length = 8) Then


            key = TextBox1.Text
            ir1 = Mid$(key, 1, 2)
            ir2 = Mid$(key, 3, 2)
            ir3 = Mid$(key, 5, 2)
            qtdvar = Mid$(key, 7, 2)
            If ((ir1 > 39) Or (ir2 > 39) Or (ir3 > 39)) Then
                Return False
            End If
            Return True

        Else
            Return False

        End If
    End Function

    Function limparrotores()
        Dim c As Integer

        For c = 0 To r1trab.Length - 1
            r1trab(c) = ""
        Next

        For c = 0 To r2trab.Length - 1
            r2trab(c) = ""
        Next

        For c = 0 To r3trab.Length - 1
            r3trab(c) = ""
        Next
    End Function

    Function reposicionainicialrray() 'reposiciona o array de acordo com a possiçao inicial
        Dim prov(r1.Length - 1) As String
        Dim c As Integer = 0
        limparrotores()

        'rotor1

        'verifica se o inicial do rotor 1 e maior que zero, caso seja reorganiza o rotor 1
        If ir1 > 0 Then
            ' reorganiza do ponto proposto ate o final
            For c = 0 To (r1.Length - 1)
                If c < (r1.Length - ir1) Then
                    prov(c) = r1(ir1 + c)
                End If
            Next
            'reorganiza do ponto inicial ao proposto.
            For c = 0 To (ir1 - 1)
                prov(r1.Length - ir1 + c) = r1(c)
            Next
            'transfere da variavel temporaria para a original
            For c = 0 To r1.Length - 1
                r1trab(c) = prov(c)
            Next

        End If



        'rotor2

        'verifica se o inicial do rotor 1 e maior que zero, caso seja reorganiza o rotor 1
        If ir2 > 0 Then
            ' reorganiza do ponto proposto ate o final
            For c = 0 To (r2.Length - 1)
                If c < (r2.Length - ir2) Then
                    prov(c) = r2(ir2 + c)
                End If
            Next
            'reorganiza do ponto inicial ao proposto.
            For c = 0 To (ir2 - 1)
                prov(r2.Length - ir2 + c) = r2(c)
            Next
            'transfere da variavel temporaria para a original
            For c = 0 To r2.Length - 1
                r2trab(c) = prov(c)
            Next

        End If

        'rotor3

        'verifica se o inicial do rotor 1 e maior que zero, caso seja reorganiza o rotor 1
        If ir3 > 0 Then
            ' reorganiza do ponto proposto ate o final
            For c = 0 To (r3.Length - 1)
                If c < (r3.Length - ir3) Then
                    prov(c) = r3(ir3 + c)
                End If
            Next
            'reorganiza do ponto inicial ao proposto.
            For c = 0 To (ir3 - 1)
                prov(r3.Length - ir3 + c) = r3(c)
            Next
            'transfere da variavel temporaria para a original
            For c = 0 To r3.Length - 1
                r3trab(c) = prov(c)
            Next

        End If

    End Function

    Function repoarray(ByVal num As Integer, ByVal nl As Integer) 'reposiciona o array a cada tecla precionada

        Dim c As Integer = 0
        Dim mov As Integer = nl * qtdvar

        If num = 1 Then 'rotor1

            Dim prov(r1trab.Length - 1) As String
            Dim provretorno(r1trab.Length - 1) As String

            While ((mov / (r1trab.Length - 1)) >= 1)  ' faz a variavel de movimentaçao ficar correta no rotor
                mov = mov - (r1trab.Length - 1)
            End While

            'If (mov / (r1trab.Length - 1) = 1) Then  'erro de chegar no final para os outros 
            'mov = 0
            '      End If

            ' reorganiza do ponto proposto ate o final
            For c = 0 To (r1trab.Length - 1)
                If c < (r1trab.Length - mov) Then
                    prov(c) = r1trab(mov + c)
                End If
            Next
            'reorganiza do ponto inicial ao proposto.
            For c = 0 To (mov - 1)
                prov(r1trab.Length - mov + c) = r1trab(c)
            Next

            'transfere da variavel temporaria para a original
            For c = 0 To r1trab.Length - 1
                provretorno(c) = prov(c)
            Next
            Return provretorno




        ElseIf num = 2 Then 'rotor2

            Dim prov(r2trab.Length - 1) As String
            Dim provretorno(r2trab.Length - 1) As String

            While ((mov / (r2trab.Length - 1)) >= 1)  ' faz a variavel de movimentaçao ficar correta no rotor
                mov = mov - (r2trab.Length - 1)
            End While

            '    If (mov / (r2trab.Length - 1) = 1) Then  'erro de chegar no final para os outros 
            'mov = 0
            ' End If

            ' reorganiza do ponto proposto ate o final
            For c = 0 To (r2trab.Length - 1)
                If c < (r2trab.Length - mov) Then
                    prov(c) = r2trab(mov + c)
                End If
            Next
            'reorganiza do ponto inicial ao proposto.
            For c = 0 To (mov - 1)
                prov(r2trab.Length - mov + c) = r2trab(c)
            Next

            'transfere da variavel temporaria para a original
            For c = 0 To r2trab.Length - 1
                provretorno(c) = prov(c)
            Next
            Return provretorno




        ElseIf num = 3 Then 'rotor3

            Dim prov(r3trab.Length - 1) As String
            Dim provretorno(r3trab.Length - 1) As String

            While ((mov / (r3trab.Length - 1)) >= 1)  ' faz a variavel de movimentaçao ficar correta no rotor
                mov = mov - (r3trab.Length - 1)
            End While

            '  If (mov / (r3trab.Length - 1) = 1) Then  'erro de chegar no final para os outros 
            'mov = 0
            ' End If

            ' reorganiza do ponto proposto ate o final
            For c = 0 To (r3trab.Length - 1)
                If c < (r3trab.Length - mov) Then
                    prov(c) = r3trab(mov + c)
                End If
            Next
            'reorganiza do ponto inicial ao proposto.
            For c = 0 To (mov - 1)
                prov(r3trab.Length - mov + c) = r3trab(c)
            Next

            'transfere da variavel temporaria para a original
            For c = 0 To r3trab.Length - 1
                provretorno(c) = prov(c)
            Next
            Return provretorno

        End If


    End Function

    Function entradarotor(ByVal ent As String, ByVal c As Integer, ByVal rot As Integer) 'converte com o rotor 1. caracter por caracter
        Dim rotor() As String = repoarray(rot, c)
        Select Case ent
            Case "a"
                Return rotor(0)
            Case "b"
                Return rotor(1)
            Case "c"
                Return rotor(2)
            Case "d"
                Return rotor(3)
            Case "e"
                Return rotor(4)
            Case "f"
                Return rotor(5)
            Case "g"
                Return rotor(6)
            Case "h"
                Return rotor(7)
            Case "i"
                Return rotor(8)
            Case "j"
                Return rotor(9)
            Case "k"
                Return rotor(10)
            Case "l"
                Return rotor(11)
            Case "m"
                Return rotor(12)
            Case "n"
                Return rotor(13)
            Case "o"
                Return rotor(14)
            Case "p"
                Return rotor(15)
            Case "q"
                Return rotor(16)
            Case "r"
                Return rotor(17)
            Case "s"
                Return rotor(18)
            Case "t"
                Return rotor(19)
            Case "u"
                Return rotor(20)
            Case "v"
                Return rotor(21)
            Case "w"
                Return rotor(22)
            Case "x"
                Return rotor(23)
            Case "y"
                Return rotor(24)
            Case "z"
                Return rotor(25)
            Case "0"
                Return rotor(26)
            Case "1"
                Return rotor(27)
            Case "2"
                Return rotor(28)
            Case "3"
                Return rotor(29)
            Case "4"
                Return rotor(30)
            Case "5"
                Return rotor(31)
            Case "6"
                Return rotor(32)
            Case "7"
                Return rotor(33)
            Case "8"
                Return rotor(34)
            Case "9"
                Return rotor(35)
            Case " "
                Return rotor(36)
            Case "."
                Return rotor(37)
            Case ","
                Return rotor(38)

            Case Else
                Return ent
        End Select
    End Function

    Function saidarotor(ByVal ent As String, ByVal c As Integer, ByVal rot As Integer) 'converte com o rotor. caracter por caracter
        Dim rotor() As String = repoarray(rot, c)
        Dim d As Integer = 0
        Dim controle As Integer = 0
        Dim totalrotor As Integer = rotor.Length

        Do
            If totalrotor = d Then 'verifica caso n tenha no rotor
                controle = 1
                d = 1000 'mmudar o valor para algo mto longe do case
            Else
                If rotor(d) = ent Then
                    controle = 1
                Else
                    controle = 0
                    d = d + 1
                End If
            End If

        Loop While (controle = 0)
        'nesse ponto eu descobri em c qual a possiçao que esta na saida do rotor

        'caso n tenha no rotor temos que alterar o numero para algo que nao exista no case

        Select Case d
            Case 0
                Return "a"
            Case 1
                Return "b"
            Case 2
                Return "c"
            Case 3
                Return "d"
            Case 4
                Return "e"
            Case 5
                Return "f"
            Case 6
                Return "g"
            Case 7
                Return "h"
            Case 8
                Return "i"
            Case 9
                Return "j"
            Case 10
                Return "k"
            Case 11
                Return "l"
            Case 12
                Return "m"
            Case 13
                Return "n"
            Case 14
                Return "o"
            Case 15
                Return "p"
            Case 16
                Return "q"
            Case 17
                Return "r"
            Case 18
                Return "s"
            Case 19
                Return "t"
            Case 20
                Return "u"
            Case 21
                Return "v"
            Case 22
                Return "w"
            Case 23
                Return "x"
            Case 24
                Return "y"
            Case 25
                Return "z"
            Case 26
                Return "0"
            Case 27
                Return "1"
            Case 28
                Return "2"
            Case 29
                Return "3"
            Case 30
                Return "4"
            Case 31
                Return "5"
            Case 32
                Return "6"
            Case 33
                Return "7"
            Case 34
                Return "8"
            Case 35
                Return "9"
            Case 36
                Return " "
            Case 37
                Return "."
            Case 38
                Return ","

            Case Else
                Return ent
        End Select
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nome_arquivo_ini_r1 As String = nomeArquivoINI(1)
        Dim nome_arquivo_ini_r2 As String = nomeArquivoINI(2)
        Dim nome_arquivo_ini_r3 As String = nomeArquivoINI(3)
        Dim c As Integer = 0
        Dim d As Integer = 0
        'rotor 1 
        For c = 0 To (r1.Length - 1)

            r1(c) = LeArquivoINI(nome_arquivo_ini_r1, "rotor", "v" + c.ToString, "ERRO")
            r1trab(c) = LeArquivoINI(nome_arquivo_ini_r1, "rotor", "v" + c.ToString, "ERRO")
        Next
        ' rotor 2
        For c = 0 To (r2.Length - 1)

            r2(c) = LeArquivoINI(nome_arquivo_ini_r2, "rotor", "v" + c.ToString, "ERRO")
            r2trab(c) = LeArquivoINI(nome_arquivo_ini_r2, "rotor", "v" + c.ToString, "ERRO")
        Next
        'rotor 3
        For c = 0 To (r3.Length - 1)

            r3(c) = LeArquivoINI(nome_arquivo_ini_r3, "rotor", "v" + c.ToString, "ERRO")
            r3trab(c) = LeArquivoINI(nome_arquivo_ini_r3, "rotor", "v" + c.ToString, "ERRO")
        Next

        'verificaçao de rotor
        For c = 0 To (r1.Length - 1)
            For d = 0 To (r1.Length - 1)
                If c <> d Then
                    If r1(c) = r1(d) Then
                        MsgBox("PRobema")
                    End If
                End If
            Next

        Next


        For c = 0 To (r2.Length - 1)
            For d = 0 To (r2.Length - 1)
                If c <> d Then
                    If r2(c) = r2(d) Then
                        MsgBox("PRobema")
                    End If
                End If
            Next

        Next


        For c = 0 To (r3.Length - 1)
            For d = 0 To (r3.Length - 1)
                If c <> d Then
                    If r3(c) = r3(d) Then
                        MsgBox("PRobema")
                    End If
                End If
            Next

        Next

    End Sub

    Private Sub btn_gerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gerar.Click
        Dim c As Integer = 0
        Dim entrada As String = texto1.Text
        Dim arrayentrada(Len(entrada)) As String

        Dim saida As String = ""
        Dim arraysaida(Len(entrada)) As String

        If (rekey() = False) Then
            MsgBox("Codigo Invalido")
            Exit Sub
        End If

        'preenche as variaveis de chave
        reposicionainicialrray() 'remonta o array para a postura da chave inicial

        For c = 1 To Len(entrada) 'converve a entrada em um array
            arrayentrada(c) = Mid$(entrada, c, 1)
        Next

        For c = 1 To Len(entrada) ' faz passar pelo rotor 1 letra a letra
            arraysaida(c) = entradarotor(RemoveAcentos(Mid$(entrada, c, 1).ToLower), c, 1) 'passa pelo rotor 1 apenas a primeira letra
            arraysaida(c) = entradarotor(arraysaida(c), c, 2) 'repasasa a letra no rotor 2
            arraysaida(c) = entradarotor(arraysaida(c), c, 3)
        Next
        For c = 1 To Len(entrada) 'converte a saida de array para string
            saida = saida + arraysaida(c)
        Next
        texto2.Text = saida.ToString 'espoe a saida do array no text
    End Sub


    Private Sub btn_decriptografar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_decriptografar.Click
        Dim c As Integer = 0

        Dim saida As String = texto2.Text
        Dim arraysaida(Len(saida)) As String

        Dim entrada As String
        Dim arrayentrada(Len(saida)) As String



        rekey() 'preenche as variaveis de chave
        reposicionainicialrray() 'remonta o array para a postura da chave inicial

        For c = 1 To Len(saida) 'converve a saida em um array
            arraysaida(c) = Mid$(saida, c, 1)
        Next
        '
        For c = 1 To Len(saida) ' faz passar pelo rotor 1 letra a letra <devese inferter os rotores na saida
            arrayentrada(c) = saidarotor(Mid$(saida, c, 1), c, 3) 'passa pelo rotor 1 apenas a primeira letra
            arrayentrada(c) = saidarotor(arrayentrada(c), c, 2) 'repasasa a letra no rotor 2
            arrayentrada(c) = saidarotor(arrayentrada(c), c, 1)
        Next
        For c = 1 To Len(saida) 'converte a entrada de array para string
            entrada = entrada + arrayentrada(c)
        Next
        texto1.Text = entrada.ToString 'espoe a saida do array no text
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        MessageBox.Show("Este programa foi elaborado como uma prova de conceito acadêmico." + Chr(13) + "Tudo que for feito por seus usuários é de inteira responsabilidade dos mesmos." + Chr(13) + Chr(13) + "O Enigma LITE utiliza um sistema criptográfico extremamente semelhante ao utilizado pelos alemães na 2º Guerra Mundial." + Chr(13) + " uma criptográfica complexa com vários níveis, baseada no sistema de rotores e randomização  automática, tornando assim" + Chr(13) + " extremamente difícil sua quebra." + Chr(13) + Chr(13) + "Data inicial do projeto: 05/01/2014" + Chr(13) + "Licença: GPL" + Chr(13) + Chr(13) + "www.professorbaruffi.com.br", "Enigma LITE", MessageBoxButtons.OK)
    End Sub

    Private Sub ModoDeUsarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModoDeUsarToolStripMenuItem.Click
        MessageBox.Show("Modo de usar. " + Chr(13) + Chr(13) + Chr(13) + "Para utilizar esta criptografia as duas partes devem possuir uma copia do programa," + Chr(13) + " os mesmos rotores (Arquivos INI presentes juntos do programa) e conhecer a mesma chave." + Chr(13) + Chr(13) + " Depois disso é só passar as mensagens por meios publicos", "Enigma LITE", MessageBoxButtons.OK)
    End Sub

    Private Sub btn_ajuda_chave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ajuda_chave.Click
        MessageBox.Show("Como criar sua chave." + Chr(13) + Chr(13) + Chr(13) + "A chave é composta por 4 grupos numericos de dois digitos de 01 a 39. " + Chr(13) + Chr(13) + "Exemplo:" + Chr(13) + "Correto: 05362516" + Chr(13) + "Incorreto: 88459947", "Enigma LITE", MessageBoxButtons.OK)
    End Sub
End Class
