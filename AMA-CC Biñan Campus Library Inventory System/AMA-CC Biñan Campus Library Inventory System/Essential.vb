Imports System.Data.OleDb
Module Essential
    Public cn As New OleDbConnection
    Public cmfname, cmmname, cmlname, cmlogin, cmutype, cmalogin, cmulogin, cmbutype, cmbedit, cmbstatus, cmqsb, cmbitb, cmutags, cmgy, cmsc, cmbdl, cmbdb As New OleDbCommand
    Public cmbid, cmbn, cmba, cmbg, cmby, cmpb, cmstatus, cmbd, cmnote, cmbb, cmtags, cmloc, cmitb, cmhstid As New OleDbCommand
    Public cmuid, cmfn, cmmn, cmln, cmad, cmconu, cmut, cmpw As New OleDbCommand
    Public cmfnote1, cmfnote2 As New OleDbCommand
    Public cmadd, cmedit, cmdel, cmhsadd As New OleDbCommand
    Public login, fnote, alogin, ulogcon As OleDbDataReader
    Public CUsername, CPassword As String
    Public procbtnB As Char
    Public ds As New DataSet
    Public dt As DataTable
    Public da As OleDbDataAdapter
    Public tables As DataTableCollection
    Public source1 As New BindingSource
    Public fname, mname, lname, utype, txtfnote, qsb, butype, bbstatus As String
    Public BID, ITB As Integer
    Public BN, BA, BG, BY, PB, Status, BStatus, BD, Note, BB, bBB, Tags, LOC, FN, MN, LN, AD, CONU, UT, PW, UID, UTags, GY, SC, LOGUID, PCN, BDeadline, BDBorrowed As String
    Public TransID, BRUID, BRStatus, BRDD, BRBID, BRBB, BRPCN As String
    Public hBID, hBN, hBA, hBG, hBY, hPB, hStatus, hDD, hBB, hDR, hTIDRead, hTID As String
    Public Sub connectstart()
        With cn
            cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\AMAInvDB.mdb")
        End With
    End Sub
    Public Sub libinf()
        With cmadd
            cmadd = New OleDbCommand("INSERT INTO LibInv VALUES(@BID, @BN, @BA, @BG, @BY, @PB, @Status, @BD, @Note, @BB, @TAGS, @LOC, @BDD, @BDB)", cn)
            cmadd.Parameters.Add(New OleDbParameter("@BID", BID))
            cmadd.Parameters.Add(New OleDbParameter("@BN", BN))
            cmadd.Parameters.Add(New OleDbParameter("@BA", BA))
            cmadd.Parameters.Add(New OleDbParameter("@BG", BG))
            cmadd.Parameters.Add(New OleDbParameter("@BY", BY))
            cmadd.Parameters.Add(New OleDbParameter("@PB", PB))
            cmadd.Parameters.Add(New OleDbParameter("@Status", Status))
            cmadd.Parameters.Add(New OleDbParameter("@BD", BD))
            cmadd.Parameters.Add(New OleDbParameter("@Note", Note))
            cmadd.Parameters.Add(New OleDbParameter("@BB", BB))
            cmadd.Parameters.Add(New OleDbParameter("@TAGS", Tags))
            cmadd.Parameters.Add(New OleDbParameter("@LOC", LOC))
            cmadd.Parameters.Add(New OleDbParameter("@BDD", BDeadline))
            cmadd.Parameters.Add(New OleDbParameter("@BDB", BDBorrowed))
        End With
        With cmdel
            cmdel = New OleDbCommand("DELETE * FROM LibInv WHERE [BookID] = @BID", cn)
            cmdel.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmedit
            cmedit = New OleDbCommand("UPDATE LibInv SET [BookID] = @BID, [BookName] = @BN, [BookAuthor] = @BA, [BookGenre] = @BG, [BookYear] = @BY, [PublishedBy] = @PB, [Status] = @Status, [BookDamage] = @BD, [Note] = @Note, [BorrowedBy] = @BB, [Location] = @LOC, [Tags] = @TAGS, [DueDate] = @BDD, [DateBorrowed] = @BDB WHERE [BookID] = @BID", cn)
            cmedit.Parameters.Add(New OleDbParameter("@BID", BID))
            cmedit.Parameters.Add(New OleDbParameter("@BN", BN))
            cmedit.Parameters.Add(New OleDbParameter("@BA", BA))
            cmedit.Parameters.Add(New OleDbParameter("@BG", BG))
            cmedit.Parameters.Add(New OleDbParameter("@BY", BY))
            cmedit.Parameters.Add(New OleDbParameter("@PB", PB))
            cmedit.Parameters.Add(New OleDbParameter("@Status", Status))
            cmedit.Parameters.Add(New OleDbParameter("@BD", BD))
            cmedit.Parameters.Add(New OleDbParameter("@Note", Note))
            cmedit.Parameters.Add(New OleDbParameter("@BB", BB))
            cmedit.Parameters.Add(New OleDbParameter("@LOC", LOC))
            cmedit.Parameters.Add(New OleDbParameter("@TAGS", Tags))
            cmedit.Parameters.Add(New OleDbParameter("@BDD", BDeadline))
            cmedit.Parameters.Add(New OleDbParameter("@BDB", BDBorrowed))
        End With
    End Sub
    Public Sub userinf()
        With cmadd
            cmadd = New OleDbCommand("INSERT INTO Users VALUES(@UID, @FN, @MN, @LN, @ADDRESS, @CN, @UTYPE, @PW, @ITB, @UTags, @GY, @SC)", cn)
            cmadd.Parameters.Add(New OleDbParameter("@UID", UID))
            cmadd.Parameters.Add(New OleDbParameter("@FN", FN))
            cmadd.Parameters.Add(New OleDbParameter("@MN", MN))
            cmadd.Parameters.Add(New OleDbParameter("@LN", LN))
            cmadd.Parameters.Add(New OleDbParameter("@ADDRESS", AD))
            cmadd.Parameters.Add(New OleDbParameter("@CN", CONU))
            cmadd.Parameters.Add(New OleDbParameter("@UTYPE", UT))
            cmadd.Parameters.Add(New OleDbParameter("@PW", PW))
            cmadd.Parameters.Add(New OleDbParameter("@ITB", ITB))
            cmadd.Parameters.Add(New OleDbParameter("@UTags", UTags))
            cmadd.Parameters.Add(New OleDbParameter("@GY", GY))
            cmadd.Parameters.Add(New OleDbParameter("@SC", SC))
        End With
        With cmdel
            cmdel = New OleDbCommand("DELETE * FROM Users WHERE [ID] = @UID", cn)
            cmdel.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmedit
            cmedit = New OleDbCommand("UPDATE Users SET [ID] = @UID, [F_Name] = @FN, [M_Name] = @MN, [L_Name] = @LN, [Address] = @ADDRESS, [ContactNumber] = @CN, [UserType] = @UTYPE, [Password] = @PW, [ItemsBorrowed] = @ITB, [Tags] = @UTags, [Grade/Year] = @GY, [Section/Course] = @SC WHERE [ID] = @UID", cn)
            cmedit.Parameters.Add(New OleDbParameter("@UID", UID))
            cmedit.Parameters.Add(New OleDbParameter("@FN", FN))
            cmedit.Parameters.Add(New OleDbParameter("@MN", MN))
            cmedit.Parameters.Add(New OleDbParameter("@LN", LN))
            cmedit.Parameters.Add(New OleDbParameter("@ADDRESS", AD))
            cmedit.Parameters.Add(New OleDbParameter("@CN", CONU))
            cmedit.Parameters.Add(New OleDbParameter("@UTYPE", UT))
            cmedit.Parameters.Add(New OleDbParameter("@PW", PW))
            cmedit.Parameters.Add(New OleDbParameter("@ITB", ITB))
            cmedit.Parameters.Add(New OleDbParameter("@UTags", UTags))
            cmedit.Parameters.Add(New OleDbParameter("@GY", GY))
            cmedit.Parameters.Add(New OleDbParameter("@SC", SC))
        End With
    End Sub
    Public Sub libinfedit()
        With cmbid
            cmbid = New OleDbCommand("SELECT BookID FROM LibInv WHERE BookID = @BID", cn)
            cmbid.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmbn
            cmbn = New OleDbCommand("SELECT BookName FROM LibInv WHERE BookID = @BID", cn)
            cmbn.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmba
            cmba = New OleDbCommand("SELECT BookAuthor FROM LibInv WHERE BookID = @BID", cn)
            cmba.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmbg
            cmbg = New OleDbCommand("SELECT BookGenre FROM LibInv WHERE BookID = @BID", cn)
            cmbg.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmby
            cmby = New OleDbCommand("SELECT BookYear FROM LibInv WHERE BookID = @BID", cn)
            cmby.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmpb
            cmpb = New OleDbCommand("SELECT PublishedBy FROM LibInv WHERE BookID = @BID", cn)
            cmpb.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmstatus
            cmstatus = New OleDbCommand("SELECT Status FROM LibInv WHERE BookID = @BID", cn)
            cmstatus.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmbd
            cmbd = New OleDbCommand("SELECT BookDamage FROM LibInv WHERE BookID = @BID", cn)
            cmbd.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmnote
            cmnote = New OleDbCommand("SELECT Note FROM LibInv WHERE BookID = @BID", cn)
            cmnote.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmbb
            cmbb = New OleDbCommand("SELECT BorrowedBy FROM LibInv WHERE BookID = @BID", cn)
            cmbb.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmtags
            cmtags = New OleDbCommand("SELECT Tags FROM LibInv WHERE BookID = @BID", cn)
            cmtags.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmloc
            cmloc = New OleDbCommand("SELECT Location FROM LibInv WHERE BookID = @BID", cn)
            cmloc.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmbdl
            cmbdl = New OleDbCommand("SELECT DueDate FROM LibInv WHERE BookID = @BID", cn)
            cmbdl.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
        With cmbdb
            cmbdb = New OleDbCommand("SELECT DateBorrowed FROM LibInv WHERE BookID = @BID", cn)
            cmbdb.Parameters.Add(New OleDbParameter("@BID", BID))
        End With
    End Sub
    Public Sub userinfedit()
        With cmuid
            cmuid = New OleDbCommand("SELECT ID FROM Users WHERE ID = @UID", cn)
            cmuid.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmfn
            cmfn = New OleDbCommand("SELECT F_Name FROM Users WHERE ID = @UID", cn)
            cmfn.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmmn
            cmmn = New OleDbCommand("SELECT M_Name FROM Users WHERE ID = @UID", cn)
            cmmn.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmln
            cmln = New OleDbCommand("SELECT L_Name FROM Users WHERE ID = @UID", cn)
            cmln.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmad
            cmad = New OleDbCommand("SELECT Address FROM Users WHERE ID = @UID", cn)
            cmad.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmconu
            cmconu = New OleDbCommand("SELECT ContactNumber FROM Users WHERE ID = @UID", cn)
            cmconu.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmpw
            cmpw = New OleDbCommand("SELECT Password FROM Users WHERE ID = @UID", cn)
            cmpw.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmitb
            cmitb = New OleDbCommand("SELECT ItemsBorrowed FROM Users WHERE ID = @UID", cn)
            cmitb.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmutags
            cmutags = New OleDbCommand("SELECT Tags FROM Users WHERE ID = @UID", cn)
            cmutags.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmgy
            cmgy = New OleDbCommand("SELECT [Grade/Year] FROM Users WHERE ID = @UID", cn)
            cmgy.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
        With cmsc
            cmsc = New OleDbCommand("SELECT [Section/Course] FROM Users WHERE ID = @UID", cn)
            cmsc.Parameters.Add(New OleDbParameter("@UID", UID))
        End With
    End Sub
End Module