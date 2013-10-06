<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
	<xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

	<xsl:template match="s3:BucketLoggingStatus">
		<xsl:element name="GetBucketLoggingResponse" namespace="{$ns}">
			<xsl:element name="BucketLoggingConfig" namespace="{$ns}">
				<xsl:apply-templates select="s3:LoggingEnabled"/>
			</xsl:element>
		</xsl:element>
	</xsl:template>

	<xsl:template match="s3:LoggingEnabled">
		<xsl:element name="TargetBucketName" namespace="{$ns}">
			<xsl:value-of select="s3:TargetBucket"/>
		</xsl:element>
		<xsl:element name="TargetPrefix" namespace="{$ns}">
			<xsl:value-of select="s3:TargetPrefix"/>
		</xsl:element>
		<xsl:apply-templates select="s3:TargetGrants"/>
	</xsl:template>

	<xsl:template match="s3:TargetGrants">
		<xsl:apply-templates select="s3:Grant"/>
	</xsl:template>
	<xsl:template match="s3:Grant">
		<xsl:element name="Grants" namespace="{$ns}">
			<xsl:apply-templates select="s3:Grantee"/>
			<xsl:element name="Permission" namespace="{$ns}">
				<xsl:value-of select="s3:Permission"/>
			</xsl:element>
		</xsl:element>
	</xsl:template>

	<xsl:template match="s3:Grantee">
		<xsl:element name="Grantee" namespace="{$ns}">
			<xsl:if test="s3:URI">
				<xsl:element name="URI" namespace="{$ns}">
					<xsl:value-of select="s3:URI"/>
				</xsl:element>
			</xsl:if>
			<xsl:if test="s3:ID and s3:DisplayName">
				<xsl:element name="CanonicalUser" namespace="{$ns}">
					<xsl:element name="First" namespace="{$ns}">
						<xsl:value-of select="s3:ID"/>
					</xsl:element>
					<xsl:element name="Second" namespace="{$ns}">
						<xsl:value-of select="s3:DisplayName"/>
					</xsl:element>
				</xsl:element>
			</xsl:if>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>