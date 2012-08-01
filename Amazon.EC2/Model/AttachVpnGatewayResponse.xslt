<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:AttachVpnGatewayResponse">
		<xsl:element name="AttachVpnGatewayResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="AttachVpnGatewayResult">
				<xsl:apply-templates select="ec2:attachment" />
			</xsl:element>
		</xsl:element>
	</xsl:template>

	<xsl:template match="ec2:attachment">
		<xsl:element name="VpcAttachment">
			<xsl:element name="VpcId">
				<xsl:value-of select="ec2:vpcId" />
			</xsl:element>
			<xsl:element name="VpcAttachmentState">
				<xsl:value-of select="ec2:state" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>
