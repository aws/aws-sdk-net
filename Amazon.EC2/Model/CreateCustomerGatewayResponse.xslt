<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:CreateCustomerGatewayResponse">
		<xsl:element name="CreateCustomerGatewayResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="CreateCustomerGatewayResult">
				<xsl:apply-templates select="ec2:customerGateway" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:customerGateway">
		<xsl:element name="CustomerGateway">
			<xsl:element name="CustomerGatewayId">
				<xsl:value-of select="ec2:customerGatewayId" />
			</xsl:element>
			<xsl:element name="CustomerGatewayState">
				<xsl:value-of select="ec2:state" />
			</xsl:element>
			<xsl:element name="Type">
				<xsl:value-of select="ec2:type" />
			</xsl:element>
			<xsl:element name="IpAddress">
				<xsl:value-of select="ec2:ipAddress" />
			</xsl:element>
			<xsl:element name="BgpAsn">
				<xsl:value-of select="ec2:bgpAsn" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>
