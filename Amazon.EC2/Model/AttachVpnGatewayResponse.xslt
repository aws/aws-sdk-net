<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-08-31/"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2010-08-31/'" />
	<xsl:template match="ec2:AttachVpnGatewayResponse">
		<xsl:element name="AttachVpnGatewayResponse" namespace="{$ns}">
			<xsl:element name="ResponseMetadata" namespace="{$ns}">
				<xsl:element name="RequestId" namespace="{$ns}">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="AttachVpnGatewayResult" namespace="{$ns}">
				<xsl:apply-templates select="ec2:attachment" />
			</xsl:element>
		</xsl:element>
	</xsl:template>

	<xsl:template match="ec2:attachment">
		<xsl:element name="VpcAttachment" namespace="{$ns}">
			<xsl:element name="VpcId" namespace="{$ns}">
				<xsl:value-of select="ec2:vpcId" />
			</xsl:element>
			<xsl:element name="VpcAttachmentState" namespace="{$ns}">
				<xsl:value-of select="ec2:state" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>
