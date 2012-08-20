<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:CreateVpnGatewayResponse">
		<xsl:element name="CreateVpnGatewayResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="CreateVpnGatewayResult">
				<xsl:apply-templates select="ec2:vpnGateway" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:vpnGateway">
		<xsl:element name="VpnGateway">
			<xsl:element name="VpnGatewayId">
				<xsl:value-of select="ec2:vpnGatewayId" />
			</xsl:element>
			<xsl:element name="VpnGatewayState">
				<xsl:value-of select="ec2:state" />
			</xsl:element>
			<xsl:element name="Type">
				<xsl:value-of select="ec2:type" />
			</xsl:element>
			<xsl:element name="AvailabilityZone">
				<xsl:value-of select="ec2:availabilityZone" />
			</xsl:element>
		</xsl:element>
	</xsl:template>

</xsl:stylesheet>

		  
