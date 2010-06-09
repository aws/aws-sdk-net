<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
	<xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>
	<xsl:template match="s3:AccessControlPolicy">
		<xsl:element name="GetACLResponse" namespace="{$ns}">
			<xsl:element name="AccessControlList" namespace="{$ns}">
				<xsl:apply-templates />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="s3:ID">
		<xsl:element name="Id" namespace="{$ns}">
			<xsl:value-of select="."/>
		</xsl:element>
	</xsl:template>

	<xsl:template match="s3:AccessControlList">
		<xsl:element name="AccessControlList" namespace="{$ns}">
			<xsl:element name="Grants" namespace="{$ns}">
				<xsl:apply-templates />
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

	<xsl:template match="@* | node()">
		<xsl:copy>
			<xsl:apply-templates select="@* | node()"/>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>