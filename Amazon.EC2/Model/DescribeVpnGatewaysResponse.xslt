<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2009-11-30/'" />
	<xsl:template match="ec2:DescribeVpnGatewaysResponse">
		<xsl:element name="DescribeVpnGatewaysResponse" namespace="{$ns}">
			<xsl:element name="ResponseMetadata" namespace="{$ns}">
				<xsl:element name="RequestId" namespace="{$ns}">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeVpnGatewaysResult" namespace="{$ns}">
				<xsl:apply-templates select="ec2:vpnGatewaySet" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:vpnGatewaySet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="VpnGateway" namespace="{$ns}">
				<xsl:element name="VpnGatewayId" namespace="{$ns}">
					<xsl:value-of select="ec2:vpnGatewayId" />
				</xsl:element>
				<xsl:element name="VpnGatewayState" namespace="{$ns}">
					<xsl:value-of select="ec2:state" />
				</xsl:element>
				<xsl:element name="Type" namespace="{$ns}">
					<xsl:value-of select="ec2:type" />
				</xsl:element>
				<xsl:element name="AvailabilityZone" namespace="{$ns}">
					<xsl:value-of select="ec2:availabilityZone" />
				</xsl:element>
				<xsl:apply-templates select="ec2:attachments" />
			</xsl:element>
		</xsl:for-each>
	</xsl:template>

	<xsl:template match="ec2:attachments">
		<xsl:for-each select="ec2:item">
			<xsl:element name="VpcAttachment" namespace="{$ns}">
				<xsl:element name="VpcId" namespace="{$ns}">
					<xsl:value-of select="ec2:vpcId" />
				</xsl:element>
				<xsl:element name="VpcAttachmentState" namespace="{$ns}">
					<xsl:value-of select="ec2:state" />
				</xsl:element>
			</xsl:element>
		</xsl:for-each>
	</xsl:template>

</xsl:stylesheet>
