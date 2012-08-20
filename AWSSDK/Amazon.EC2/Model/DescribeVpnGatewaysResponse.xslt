<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:DescribeVpnGatewaysResponse">
		<xsl:element name="DescribeVpnGatewaysResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeVpnGatewaysResult">
				<xsl:apply-templates select="ec2:vpnGatewaySet" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:vpnGatewaySet">
		<xsl:for-each select="ec2:item">
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
				<xsl:apply-templates select="ec2:attachments" />
        <xsl:apply-templates select="ec2:tagSet" />
			</xsl:element>
		</xsl:for-each>
	</xsl:template>

	<xsl:template match="ec2:attachments">
		<xsl:for-each select="ec2:item">
			<xsl:element name="VpcAttachment">
				<xsl:element name="VpcId">
					<xsl:value-of select="ec2:vpcId" />
				</xsl:element>
				<xsl:element name="VpcAttachmentState">
					<xsl:value-of select="ec2:state" />
				</xsl:element>
			</xsl:element>
		</xsl:for-each>
	</xsl:template>
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag">
        <xsl:element name="Key">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
