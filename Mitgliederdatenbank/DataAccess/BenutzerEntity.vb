'------------------------------------------------------------------------------
' <auto-generated>
'    Dieser Code wurde aus einer Vorlage generiert.
'
'    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
'    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class BenutzerEntity
    Public Property benIdPK As Integer
    Public Property benName As String
    Public Property benPasswort As String
    Public Property benVersion As Byte()
    Public Property benIstAdmin As Nullable(Of Boolean)
    Public Property benIstVorgesetzter As Nullable(Of Boolean)

    Public Overridable Property tblTrainingseinheiten As ICollection(Of TrainingseinheitEntity) = New HashSet(Of TrainingseinheitEntity)

End Class
