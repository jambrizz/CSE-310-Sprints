import java.time.LocalDate
import java.time.format.DateTimeFormatter

fun main(args: Array<String>) {
    var mainMenuRun = true
    do {
        println("Welcome to Notes App!")
        println("1. Create a note")
        println("2. Delete a note")
        println("3. Edit a note")
        println("4. List all notes")
        println("5. Exit")
        println("Enter your choice: ")

        val choice = readLine()!!

        fun checkChoice(toCheck: String): Boolean {
            return toCheck.all { char -> char.isDigit() }
        }

        val check = checkChoice(choice)
        //println(check)
        if (check == false){
            println("Invalid choice, please enter a number between 1 and 5")
        }
        else {

            val x = choice.toInt()
            when (x) {
                1 -> {
                    println("Create a note!")
                    val cNote = CreateNote()
                    val note = cNote.createNote()
                    println(note)

                    //mainMenuRun = false
                }
                2 -> {
                    println("Delete a note!")
                    mainMenuRun = false
                }
                3 -> {
                    println("Edit a note!")
                    mainMenuRun = false
                }
                4 -> {
                    println("List all notes!")
                    mainMenuRun = false
                }
                5 -> {
                    println("Exiting...")
                    mainMenuRun = false
                }
                else -> {
                    println("Invalid choice!")
                }
            }
        }

    }
    while (mainMenuRun)

    /*

     */

    // Try adding program arguments via Run/Debug configuration.
    // Learn more about running applications: https://www.jetbrains.com/help/idea/running-applications.html.
    //println("Program arguments: ${args.joinToString()}")
}