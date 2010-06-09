<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        xmlns:cf="http://cloudfront.amazonaws.com/doc/2009-12-01/" exclude-result-prefixes="xsl cf">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
	<xsl:variable name="ns" select="'http://cloudfront.amazonaws.com/doc/2009-12-01/'"/>

	<xsl:template match="cf:DistributionList">
		<xsl:element name="ListDistributionsResponse" namespace="{$ns}">
			<xsl:apply-templates/>
		</xsl:element>
	</xsl:template>

	<xsl:template match="cf:DistributionSummary">
		<xsl:element name="Distribution" namespace="{$ns}">
			<xsl:apply-templates/>
		</xsl:element>
	</xsl:template>

	<xsl:template match="cf:Bucket[local-name(..)='Logging']">
		<xsl:element name="First" namespace="{$ns}">
			<xsl:value-of select="."/>
		</xsl:element>
	</xsl:template>

	<xsl:template match="cf:Prefix[local-name(..)='Logging']">
		<xsl:element name="Second" namespace="{$ns}">
			<xsl:value-of select="."/>
		</xsl:element>
	</xsl:template>

	<xsl:template match="@* | node()">
		<xsl:copy>
			<xsl:apply-templates select="@* | node()"/>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>