<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
    <xsl:template match="ec2:DescribeRegionsResponse">
        <xsl:element name="DescribeRegionsResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeRegionsResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:regionInfo"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:regionInfo">
        <xsl:for-each select="ec2:item">
            <xsl:element name="Region" namespace="{$ns}">
                <xsl:element name="RegionName" namespace="{$ns}">
                    <xsl:value-of select="ec2:regionName"/>
                </xsl:element>
                <xsl:element name="Endpoint" namespace="{$ns}">
                    <xsl:value-of select="ec2:regionEndpoint"/>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
