<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
    exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
    <xsl:template match="ec2:DescribeSpotDatafeedSubscriptionResponse">
        <xsl:element name="DescribeSpotDatafeedSubscriptionResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId" />
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeSpotDatafeedSubscriptionResult">
                <xsl:apply-templates select="ec2:spotDatafeedSubscription"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:spotDatafeedSubscription">
        <xsl:element name="SpotDatafeedSubscription">
            <xsl:element name="OwnerId">
                <xsl:value-of select="ec2:ownerId"/>
            </xsl:element>
            <xsl:element name="Bucket">
                <xsl:value-of select="ec2:bucket"/>
            </xsl:element>
            <xsl:element name="Prefix">
                <xsl:value-of select="ec2:prefix"/>
            </xsl:element>
            <xsl:element name="State">
                <xsl:value-of select="ec2:state"/>
            </xsl:element>
            <xsl:apply-templates select="ec2:fault"/>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:fault">
        <xsl:element name="Fault">
            <xsl:element name="Code">
                <xsl:value-of select="ec2:code" />
            </xsl:element>
            <xsl:element name="Message">
                <xsl:value-of select="ec2:message" />
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
