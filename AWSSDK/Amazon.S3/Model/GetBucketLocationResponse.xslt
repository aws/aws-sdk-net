<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="s3">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
	<xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>
	<xsl:template match="s3:LocationConstraint">
		<xsl:element name="GetBucketLocationResponse" namespace="{$ns}">
			<xsl:choose>
				<xsl:when test="../s3:LocationConstraint=''">
					<xsl:element name="Location" namespace="{$ns}">US</xsl:element>
				</xsl:when>
				<xsl:otherwise>
					<xsl:element name="Location" namespace="{$ns}">
						<xsl:value-of select="../s3:LocationConstraint"/>
					</xsl:element>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>