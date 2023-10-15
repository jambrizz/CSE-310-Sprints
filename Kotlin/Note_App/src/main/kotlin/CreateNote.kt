import java.time.LocalDate
import java.time.format.DateTimeFormatter


class CreateNote {
    fun createNote(): String {
        println("Create a note!")

        println("Enter the note title: ")
        val noteTitle = readLine().toString()

        println("Enter the note content: ")
        val noteContent = readLine().toString()

        println("Enter the note importance: 1.High 2.Medium 3.Low")
        val noteImportance = readLine().toString()

        val date = LocalDate.now()
        val formatter = DateTimeFormatter.ofPattern("MM-dd-yyyy")
        val formattedDate = date.format(formatter)

        return "Date:$formattedDate, Title:$noteTitle, Content:$noteContent, Priority:$noteImportance"
    }


}