<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:template match="ec2:CreateRouteTableResponse">
    <xsl:element name="CreateRouteTableResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="CreateRouteTableResult">
        <xsl:apply-templates select="ec2:routeTable" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:routeTable">
    <xsl:element name="RouteTable">
      <xsl:element name="RouteTableId">
        <xsl:value-of select="ec2:routeTableId" />
      </xsl:element>
      <xsl:element name="VpcId">
        <xsl:value-of select="ec2:vpcId" />
      </xsl:element>

      <xsl:apply-templates select="ec2:routeSet" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:routeSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Routes">
        <xsl:element name="DestinationCidrBlock">
          <xsl:value-of select="ec2:destinationCidrBlock" />
        </xsl:element>
        <xsl:element name="GatewayId">
          <xsl:value-of select="ec2:gatewayId" />
        </xsl:element>
        <xsl:element name="State">
          <xsl:value-of select="ec2:state" />
        </xsl:element>
        <xsl:element name="NetworkInterfaceId">
          <xsl:value-of select="ec2:networkInterfaceId" />
        </xsl:element>
        <xsl:element name="InstanceOwnerId">
          <xsl:value-of select="ec2:instanceOwnerId" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
