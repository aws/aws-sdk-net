<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:DescribeVpnConnectionsResponse">
		<xsl:element name="DescribeVpnConnectionsResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeVpnConnectionsResult">
				<xsl:apply-templates select="ec2:vpnConnectionSet" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:vpnConnectionSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="VpnConnection">
				<xsl:element name="VpnConnectionId">
					<xsl:value-of select="ec2:vpnConnectionId" />
				</xsl:element>
				<xsl:element name="VpnConnectionState">
					<xsl:value-of select="ec2:state" />
				</xsl:element>
				<xsl:element name="CustomerGatewayConfiguration">
					<xsl:value-of select="ec2:customerGatewayConfiguration" />
				</xsl:element>
				<xsl:element name="Type">
					<xsl:value-of select="ec2:type" />
				</xsl:element>
				<xsl:element name="CustomerGatewayId">
					<xsl:value-of select="ec2:customerGatewayId" />
				</xsl:element>
				<xsl:element name="VpnGatewayId">
					<xsl:value-of select="ec2:vpnGatewayId" />
				</xsl:element>
        <xsl:apply-templates select="ec2:tagSet" />
        <xsl:apply-templates select="ec2:vgwTelemetry" />
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
  <xsl:template match="ec2:vgwTelemetry">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VpnTunnelTelemetry">
        <xsl:element name="OutsideIpAddress">
          <xsl:value-of select="ec2:outsideIpAddress" />
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status" />
        </xsl:element>
        <xsl:element name="LastStatusChange">
          <xsl:value-of select="ec2:lastStatusChange" />
        </xsl:element>
        <xsl:element name="StatusMessage">
          <xsl:value-of select="ec2:statusMessage" />
        </xsl:element>
        <xsl:element name="AcceptedRouteCount">
          <xsl:value-of select="ec2:acceptedRouteCount" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
