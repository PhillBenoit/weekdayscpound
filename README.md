# weekdayscpound

![week](https://github.com/user-attachments/assets/14ce27f5-85cf-4977-a5fb-b5bdd2033dda)

Discord has a problem with their event scheduler related to DST.  I made this as a means of fixing the specific problem I was having.  I did some algebra on 3 of the algorithms found here:
[Wikipedia: Determination of the day of the week](https://en.wikipedia.org/wiki/Determination_of_the_day_of_the_week)

The algorithms return the first date for a given day of the week, month, and year.  UI then adds multiples of 7 for subsequent dates.
