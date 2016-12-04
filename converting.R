getwd()
setwd("D:/MOBILITY_HACK/bvg_data_new/bvg_data")

install.packages("gdata")
library("gdata")
mydata = read.table("16.09.28-11.32.28_Zaehldatenexport.txt", sep="\t")
write.csv(mydata, file = "bvg.csv",col.names=FALSE, sep=",")