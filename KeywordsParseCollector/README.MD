# KeywordsParseCollector

**This program was written according to the following terms of reference:**

I want a windows application written in C# .net framework 4.8.\
This must be a simple form having these Items.\
1- A panel at the top having several buttons\
like: Start, Stop, Clear and Export\
2- A rich text box for the input\
3- A DataGrid View for the output\

The application workflow:\
User enters some keywords on the richtextbox. Each line is one keyword.\
Then when user presses the Start button, it start gathering information about each keyword and show it in the gridview. Export button must export the datagridvew data into a csv file via using FileSaveDialog.\
Clear button clears the richtextbox.\
Gathering information takes time, so after pressing start all non-related components must be disabled and only stop button should be enabled.\
when nothing is running on the background stop button must be disabled.\
This all operations must be run on a different thread to make the app responsible.\
\
How to gethering information:\
There are several sites listed below:\
https://trimwork.co \
https://infotable.co \
https://prdctfindr.com \
https://catchanswers.com \
https://fastanswersonline.com \
https://makeanswer.com \
https://topicsmedia.com \
https://askfest.com \
https://freegetanswer.com \
https://groovyanswers.com \
They are all search engines and having ads on their pages.\
There are 2 types of ads:\
1- Normal\
2- Fake (it's another search engine) which have one of these words on the description (Search, Find, Discover)\
So for each keyword we need to query one of these websites to get the results.\
For each keyword only one of these websites must be used.\
So it must rotate between websites for different keywords.\
\
The output columns:\
1- Number\
2- Keyword\
3- Date Time\
4- Number of the ads in the page\
5- Number of the Normal ads in the page\
6- Number of the Fake ads in the page\
7- Number of the ads on the top of the page\
8- Number of the Normal ads on the top of the page\
9- Number of the Fake ads on the top of the page\
