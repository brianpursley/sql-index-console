# sql-index-console
SQL Index Console is a utility for detecting SQL Server index fragmentation and rebuilding/reorganizing indexes to remove fragmentation.

## Setup
[SqlIndexConsoleSetup-1.0.3.exe](https://github.com/cinlogic/sql-index-console/releases/download/1.0.3/SqlIndexConsoleSetup-1.0.3.exe)

## Features

##### Detect Index Fragmentation
* Get a detailed list of indexes, including type, size, amount of fragmentation, and other attributes.
* Detect index and table fragmentation, including clustered index fragmentation, nonclustered index fragmentation, and heap fragmentation.
* Get automatic recommendations for whether to rebuild or reorganize each index based on thresholds you can configure.
* Sort and filter the report to find the indexes you are interested in.

##### Fix Fragmented Indexes
* Use the default recommendations or manually override the recommendation for any index by checking the Rebuild or Reorganize checkbox.
* Preview the selected actions before executing them.
* Defrag the indexes with the click of a button in SQL Index Console, or generate a T-SQL script that can be run in SQL Server Management Studio.

##### Analyze
* Export the detailed index list to Excel, CSV file, or text file so you can analyze fragmentation over time.

## Screenshots

![sqlindexconsolemain](https://cloud.githubusercontent.com/assets/4977542/8533321/5314692c-2402-11e5-88cc-1e72ed47f851.png)

![sqlindexconsolemainnoaction](https://cloud.githubusercontent.com/assets/4977542/8533322/531a13f4-2402-11e5-897e-51a9fd074e24.png)

![sqlindexconsoleoptions](https://cloud.githubusercontent.com/assets/4977542/8533323/531c3dc8-2402-11e5-83d8-25b90dec380c.png)

![sqlindexconsolepreview](https://cloud.githubusercontent.com/assets/4977542/8533325/531f07c4-2402-11e5-9da0-578b5d621d62.png)

![sqlindexconsolescript](https://cloud.githubusercontent.com/assets/4977542/8533324/531ee65e-2402-11e5-978e-cc1e737b39c2.png)
