// Kata 1: Print the first 10 even numbers
// ** OBJECTIVE** Create your own loop using the following logic**
// Commit 1: "scaffold loop structure"
for ( set ; condition ; increment )
{
    // body
}
// Commit 2: "added even number condition"
for ( int i = 1 ; i<21 ; i++ )
if ( i%2 == 0 )
{
    Console.WriteLine(i);
}
// Commit 3: "refactored variable names for clarity"
for (int i = 1; i < 21; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
