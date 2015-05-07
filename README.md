# Swaggeratr
Swagger implementation for WCF REST services (forked: include services without interfaces).

This is a fork of superstator/Swaggeratr.  I created it because the base project generates swagger exclusively from WCF Service Interfaces.  There are "legacy" WCF Services that do not implement interfaces, however, and the ability to expose these services easily is important in cases where the migration policy is to expose as REST but not rewrite.
