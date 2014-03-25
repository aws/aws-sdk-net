<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeVpcPeeringConnectionsResponse">
    <xsl:element name="DescribeVpcPeeringConnectionsResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeVpcPeeringConnectionsResult">
        <xsl:apply-templates select="ec2:vpcPeeringConnectionSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:vpcPeeringConnectionSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VpcPeeringConnection">
        <xsl:element name="VpcPeeringConnectionId">
          <xsl:value-of select="ec2:vpcPeeringConnectionId"/>
        </xsl:element>
        <xsl:element name="RequesterVpcInfo">
          <xsl:apply-templates select="ec2:requesterVpcInfo"/>
        </xsl:element>
        <xsl:element name="AccepterVpcInfo">
          <xsl:apply-templates select="ec2:accepterVpcInfo"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:apply-templates select="ec2:status"/>
        </xsl:element>
        <xsl:if test="ec2:expirationTime">
          <xsl:element name="ExpirationTime">
            <xsl:value-of select="ec2:expirationTime"/>
          </xsl:element>
        </xsl:if>
        <xsl:apply-templates select="ec2:resourceTagSet"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:requesterVpcInfo">
    <xsl:element name="OwnerId">
      <xsl:value-of select="ec2:ownerId"/>
    </xsl:element>
    <xsl:element name="VpcId">
      <xsl:value-of select="ec2:vpcId"/>
    </xsl:element>
    <xsl:element name="CidrBlock">
      <xsl:value-of select="ec2:cidrBlock"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:accepterVpcInfo">
    <xsl:element name="OwnerId">
      <xsl:value-of select="ec2:ownerId"/>
    </xsl:element>
    <xsl:element name="VpcId">
      <xsl:value-of select="ec2:vpcId"/>
    </xsl:element>
    <xsl:element name="CidrBlock">
      <xsl:value-of select="ec2:cidrBlock"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:status">
    <xsl:element name="Code">
      <xsl:value-of select="ec2:code"/>
    </xsl:element>
    <xsl:element name="Message">
      <xsl:value-of select="ec2:message"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:resourceTagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ResourceTag">
        <xsl:element name="Key">
          <xsl:value-of select="ec2:key"/>
        </xsl:element>
        <xsl:element name="Value">
          <xsl:value-of select="ec2:value"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
