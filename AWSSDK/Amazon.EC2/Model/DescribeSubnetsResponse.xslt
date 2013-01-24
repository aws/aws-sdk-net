<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:DescribeSubnetsResponse">
		<xsl:element name="DescribeSubnetsResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeSubnetsResult">
				<xsl:apply-templates select="ec2:subnetSet" />
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:subnetSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="Subnet">
				<xsl:element name="SubnetId">
					<xsl:value-of select="ec2:subnetId" />
				</xsl:element>
				<xsl:element name="SubnetState">
					<xsl:value-of select="ec2:state" />
				</xsl:element>
				<xsl:element name="VpcId">
					<xsl:value-of select="ec2:vpcId" />
				</xsl:element>
				<xsl:element name="CidrBlock">
					<xsl:value-of select="ec2:cidrBlock" />
				</xsl:element>
				<xsl:element name="AvailableIpAddressCount">
					<xsl:value-of select="ec2:availableIpAddressCount" />
				</xsl:element>
				<xsl:element name="AvailabilityZone">
					<xsl:value-of select="ec2:availabilityZone" />
				</xsl:element>
        <xsl:if test="ec2:defaultForAz">
          <xsl:element name="DefaultForAz">
            <xsl:value-of select="ec2:defaultForAz"/>
          </xsl:element>
        </xsl:if>
        <xsl:if test="ec2:mapPublicIpOnLaunch">
          <xsl:element name="MapPublicIpOnLaunch">
            <xsl:value-of select="ec2:mapPublicIpOnLaunch"/>
          </xsl:element>
        </xsl:if>
        <xsl:apply-templates select="ec2:tagSet" />
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
