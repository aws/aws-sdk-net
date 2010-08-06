<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/"
    exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
    <xsl:variable name="ns"
        select="'http://ec2.amazonaws.com/doc/2009-11-30/'" />
    <xsl:template match="ec2:DescribeSpotPriceHistoryResponse">
        <xsl:element name="DescribeSpotPriceHistoryResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId" />
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeSpotPriceHistoryResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:spotPriceHistorySet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:spotPriceHistorySet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="SpotPriceHistory" namespace="{$ns}">
                <xsl:element name="InstanceType" namespace="{$ns}">
                    <xsl:value-of select="ec2:instanceType"/>
                </xsl:element>
                <xsl:element name="ProductDescription" namespace="{$ns}">
                    <xsl:value-of select="ec2:productDescription"/>
                </xsl:element>
                <xsl:element name="SpotPrice" namespace="{$ns}">
                    <xsl:value-of select="ec2:spotPrice"/>
                </xsl:element>
                <xsl:element name="Timestamp" namespace="{$ns}">
                    <xsl:value-of select="ec2:timestamp"/>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
