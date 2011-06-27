<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-05-15/'"/>
    <xsl:template match="ec2:DescribePlacementGroupsResponse">
        <xsl:element name="DescribePlacementGroupsResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribePlacementGroupsResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:placementGroupSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:placementGroupSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="PlacementGroupInfo" namespace="{$ns}">
                <xsl:element name="GroupName" namespace="{$ns}">
                    <xsl:value-of select="ec2:groupName"/>
                </xsl:element>
                <xsl:element name="Strategy" namespace="{$ns}">
                    <xsl:value-of select="ec2:strategy"/>
                </xsl:element>
                <xsl:element name="State" namespace="{$ns}">
                    <xsl:value-of select="ec2:state"/>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>      