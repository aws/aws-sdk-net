<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-08-31/"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2010-08-31/'" />
	<xsl:template match="ec2:CreateCustomerGatewayResponse">
		<xsl:element name="CreateCustomerGatewayResponse"
			namespace="{$ns}">
			<xsl:element name="ResponseMetadata" namespace="{$ns}">
				<xsl:element name="RequestId" namespace="{$ns}">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="CreateCustomerGatewayResult"
				namespace="{$ns}">
				<xsl:apply-templates select="ec2:customerGateway" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:customerGateway">
		<xsl:element name="CustomerGateway" namespace="{$ns}">
			<xsl:element name="CustomerGatewayId" namespace="{$ns}">
				<xsl:value-of select="ec2:customerGatewayId" />
			</xsl:element>
			<xsl:element name="CustomerGatewayState" namespace="{$ns}">
				<xsl:value-of select="ec2:state" />
			</xsl:element>
			<xsl:element name="Type" namespace="{$ns}">
				<xsl:value-of select="ec2:type" />
			</xsl:element>
			<xsl:element name="IpAddress" namespace="{$ns}">
				<xsl:value-of select="ec2:ipAddress" />
			</xsl:element>
			<xsl:element name="BgpAsn" namespace="{$ns}">
				<xsl:value-of select="ec2:bgpAsn" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>
