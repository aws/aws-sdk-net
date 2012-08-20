<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
    exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
    <xsl:template match="ec2:DescribeSpotPriceHistoryResponse">
        <xsl:element name="DescribeSpotPriceHistoryResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId" />
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeSpotPriceHistoryResult">
                <xsl:apply-templates select="ec2:spotPriceHistorySet"/>
                <xsl:element name="NextToken">
                  <xsl:value-of select="ec2:nextToken"/>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:spotPriceHistorySet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="SpotPriceHistory">
                <xsl:element name="InstanceType">
                    <xsl:value-of select="ec2:instanceType"/>
                </xsl:element>
                <xsl:element name="ProductDescription">
                    <xsl:value-of select="ec2:productDescription"/>
                </xsl:element>
                <xsl:element name="SpotPrice">
                    <xsl:value-of select="ec2:spotPrice"/>
                </xsl:element>
                <xsl:element name="Timestamp">
                    <xsl:value-of select="ec2:timestamp"/>
                </xsl:element>
                <xsl:element name="AvailabilityZone">
                  <xsl:value-of select="ec2:availabilityZone"/>
                </xsl:element>              
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
