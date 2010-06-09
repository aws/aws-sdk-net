<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2009-11-30/'" />
	<xsl:template match="ec2:DescribeDhcpOptionsResponse">
		<xsl:element name="DescribeDhcpOptionsResponse" namespace="{$ns}">
			<xsl:element name="ResponseMetadata" namespace="{$ns}">
				<xsl:element name="RequestId" namespace="{$ns}">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeDhcpOptionsResult" namespace="{$ns}">
				<xsl:apply-templates select="ec2:dhcpOptionsSet" />
			</xsl:element>
		</xsl:element>
	</xsl:template>



	<xsl:template match="ec2:dhcpOptionsSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="DhcpOptions" namespace="{$ns}">
				<xsl:element name="DhcpOptionsId" namespace="{$ns}">
					<xsl:value-of select="ec2:dhcpOptionsId" />
				</xsl:element>

				<xsl:apply-templates select="ec2:dhcpConfigurationSet" />
			</xsl:element>
		</xsl:for-each>
	</xsl:template>


	<xsl:template match="ec2:dhcpConfigurationSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="Configuration" namespace="{$ns}">
				<xsl:element name="Key" namespace="{$ns}">
					<xsl:value-of select="ec2:key" />
				</xsl:element>
        		<xsl:apply-templates select="ec2:valueSet" />
			</xsl:element>
		</xsl:for-each>
	</xsl:template>

	<xsl:template match="ec2:valueSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="Value" namespace="{$ns}">
				<xsl:value-of select="ec2:value" />
			</xsl:element>
		</xsl:for-each>
	</xsl:template>
</xsl:stylesheet>
