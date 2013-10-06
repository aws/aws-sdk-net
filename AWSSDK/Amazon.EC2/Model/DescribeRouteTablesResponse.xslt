<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeRouteTablesResponse">
    <xsl:element name="DescribeRouteTablesResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeRouteTablesResult">
        <xsl:apply-templates select="ec2:routeTableSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:routeTableSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="RouteTables">
        <xsl:element name="RouteTableId">
          <xsl:value-of select="ec2:routeTableId" />
        </xsl:element>
        <xsl:element name="VpcId">
          <xsl:value-of select="ec2:vpcId" />
        </xsl:element>

        <xsl:apply-templates select="ec2:routeSet" />
        <xsl:apply-templates select="ec2:associationSet" />
        <xsl:apply-templates select="ec2:propagatingVpnGatewaySet" />
        <xsl:apply-templates select="ec2:propagatedRouteSet" />
        <xsl:apply-templates select="ec2:tagSet" />

      </xsl:element>
    </xsl:for-each>
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
          <xsl:element name="InstanceId">
            <xsl:value-of select="ec2:instanceId" />
          </xsl:element>
          <xsl:element name="InstanceOwnerId">
            <xsl:value-of select="ec2:instanceOwnerId" />
          </xsl:element>
          <xsl:element name="NetworkInterfaceId">
            <xsl:value-of select="ec2:networkInterfaceId" />
          </xsl:element>
        </xsl:element>
      </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:associationSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Associations">
        <xsl:element name="RouteTableAssociationId">
          <xsl:value-of select="ec2:routeTableAssociationId" />
        </xsl:element>
        <xsl:element name="RouteTableId">
          <xsl:value-of select="ec2:routeTableId" />
        </xsl:element>

        <xsl:apply-templates select="ec2:main" />

        <xsl:element name="SubnetId">
          <xsl:value-of select="ec2:subnetId" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:main">
    <xsl:element name="Main">
      <xsl:value-of select="." />
    </xsl:element>
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

  <xsl:template match="ec2:propagatingVpnGatewaySet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="PropagatingVpnGateway">
        <xsl:value-of select="ec2:propagatingVpnGateway" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:propagatedRouteSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="PropagatedRoute">
        <xsl:element name="DestinationCidrBlock">
          <xsl:value-of select="ec2:destinationCidrBlock" />
        </xsl:element>
        <xsl:element name="GatewayId">
          <xsl:value-of select="ec2:gatewayId" />
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status" />
        </xsl:element>
        <xsl:element name="SourceId">
          <xsl:value-of select="ec2:sourceId" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
