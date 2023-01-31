
create database BookDB;
use BookDB;
CREATE TABLE Book
(
  ISBN   int   NOT NULL ,
  BookName    varchar (50)  NOT NULL,
  Category    varchar (50)  NOT NULL,
  Author    varchar (50)  NOT NULL,
  BookDescription    varchar (1000)  NOT NULL,
  IsAvailable   char (1)  NOT NULL
  
  
)
;
/* Insert rows */
insert into Book (ISBN, BookName, Category,Author, BookDescription, IsAvailable) values (1234567,'All This Could Be Different','Adventure','Sarah Thankam Mathews','Showing up for your community, your family, and your loved ones is not always easy. It can actually be quite terrifying if you aren’t fully comfortable with yourself. Sneha—a young Indian immigrant who arrived in the U.S. with her parents as a teenager but is now alone after her father’s deportation—is a new college graduate working an entry level job that, demoralizing as it is, keeps her paid and allows her to stay in the country. ','Y' );
insert into Book (ISBN, BookName, Category,Author, BookDescription, IsAvailable) values (1224567,'An Immerse World','Animals','Ed Yong','Pulitzer Prize-winning science journalist Ed Yong has been one of the must-read voices throughout the COVID-19 pandemic. In An Immense World: How Animal Senses Reveal the Hidden Realms Around Us, he turns his attention to lighter but equally fascinating fare: the unique ways in which animals experience their surroundings. Readers learn how bats use echolocation to navigate, dogs rely on scent, and eels emit electric signals. Prepare to be wowed by crocodiles’ sensitive skin, giant squids’ eyes—which are as big as soccer balls—and catfishes’ full-body tastebuds. ','Y' );
insert into Book (ISBN, BookName, Category,Author, BookDescription, IsAvailable) values (1224367,'World Travel An Irreverent Guide','Travel','Anthony Bourdain','Had to cancel your dream vacation due to the pandemic? This posthumous collection of essays and reflections captures the late travel and food writer and TV host Anthony Bourdains favorite places on the planet—and may just inspire your future travels.','Y' );
insert into Book (ISBN, BookName, Category,Author, BookDescription, IsAvailable) values (2224567,'Trick Mirror Reflections on Self-Delusion','Self Improvement','Jia Tolentino','In her debut collection of nine original essays, the popular NewYorker.com writer interrogates everything from millennial scammers to the Internet. Its compulsively readable, thanks in large part to Tolentinos own self-reflection and autobiographical elements. ','N' );
insert into Book (ISBN, BookName, Category,Author, BookDescription, IsAvailable) values (3224567,'246 The Power of Unplugging One Day a Week','Self Improvement','Tiffany Shlain','In 24/6, filmmaker and popular speaker Shlain introduces readers to what she calls a "Technology Shabbat"—the one day, every week, where she and her family turn off all electronic devices. Beyond detailing the many ways she and her family have benefited, Shlain gives helpful, reassuring advice for embracing your own tech shabbat and curbing device use.','Y' );
