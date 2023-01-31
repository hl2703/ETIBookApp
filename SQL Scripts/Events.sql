Create Database myEventsDB
use myEventsDB;
CREATE TABLE myEvents
(
  EventID				int NOT NULL,
  EventName				varchar(255) 	NOT NULL,
  EventDescription		varchar(8000) 	NOT NULL,
  DateTimePosted		datetime		NOT NULL DEFAULT (getdate()),
  StartDate				datetime		NULL, 
  EndDate				datetime		NULL,
 
) 


INSERT into myEvents (EventID,EventName,EventDescription,DateTimePosted,StartDate,EndDate) 
VALUES (1, 'Borrow and win','Borrow 5 books during the event period and stand a chance to win a StarBucks gift card!','1-Nov-2021 03:09:20','15-Nov-2021','20-Nov-2021')

INSERT into myEvents (EventID,EventName,EventDescription,DateTimePosted,StartDate,EndDate) 
VALUES (2, 'Book Buffet','Give these books a second life. Grab a free book during this period','1-Nov-2022 03:09:20','15-Nov-2022','20-Nov-2022')

