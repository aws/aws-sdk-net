<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeAvailabilityZonesResponse">
        <xsl:element name="DescribeAvailabilityZonesResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeAvailabilityZonesResult">
                <xsl:apply-templates select="ec2:availabilityZoneInfo"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:availabilityZoneInfo">
        <xsl:apply-templates select="ec2:item"/>
    </xsl:template>
    <xsl:template match="ec2:item">
        <xsl:element name="AvailabilityZone">
            <xsl:element name="ZoneName">
                <xsl:value-of select="ec2:zoneName"/>
            </xsl:element>
            <xsl:element name="ZoneState">
                <xsl:value-of select="ec2:zoneState"/>
            </xsl:element>
			<xsl:element name="RegionName">
				<xsl:value-of select="ec2:regionName" />
			</xsl:element>
			<xsl:apply-templates select="ec2:messageSet"/>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:messageSet">
	 <xsl:for-each select="ec2:item">
		<xsl:element name="Message">
			<xsl:value-of select="ec2:message" />
        </xsl:element>
    </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>


