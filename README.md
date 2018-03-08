# VPImp

Visual Photo IMPorter--VPImp--is exactly what it's advertised to be on the tin--
a photo import tool. More important: It's the Winforms answer to PImp--the 
command line photo import tool I created.

Photos are moved from the source (Import From:) folder into the destination (To:)
folder and stored in folders organized by the date the photos were taken.

Some improvements have been made from the command line version. For example: 
VPImp reads the file EXIF data to determine when the photo was shot instead of 
making an assumption based on the dates accessible via the file system.

Unfortunately (for now) VPImp only supports JPG. My immediate plans are to include
CR2 as well since those are the formats output by my equipment. 

I am willing to support more formats but only on request.
