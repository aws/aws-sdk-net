<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribePlacementGroupsResponse">
        <xsl:element name="DescribePlacementGroupsResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribePlacementGroupsResult">
                <xsl:apply-templates select="ec2:placementGroupSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:placementGroupSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="PlacementGroupInfo">
                <xsl:element name="GroupName">
                    <xsl:value-of select="ec2:groupName"/>
                </xsl:element>
                <xsl:element name="Strategy">
                    <xsl:value-of select="ec2:strategy"/>
                </xsl:element>
                <xsl:element name="State">
                    <xsl:value-of select="ec2:state"/>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>      