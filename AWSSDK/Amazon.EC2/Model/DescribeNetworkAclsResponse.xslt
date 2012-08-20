<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeNetworkAclsResponse">
    <xsl:element name="DescribeNetworkAclsResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeNetworkAclsResult">
        <xsl:apply-templates select="ec2:networkAclSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="ec2:networkAclSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="NetworkAcls">
        <xsl:element name="NetworkAclId">
          <xsl:value-of select="ec2:networkAclId" />
        </xsl:element>
        <xsl:element name="VpcId">
          <xsl:value-of select="ec2:vpcId" />
        </xsl:element>
        <xsl:element name="Default">
          <xsl:value-of select="ec2:default" />
        </xsl:element>

        <xsl:apply-templates select="ec2:entrySet" />
        <xsl:apply-templates select="ec2:associationSet" />
        <xsl:apply-templates select="ec2:tagSet" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:entrySet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Entries">
        <xsl:element name="RuleNumber">
          <xsl:value-of select="ec2:ruleNumber" />
        </xsl:element>
        <xsl:element name="Protocol">
          <xsl:value-of select="ec2:protocol" />
        </xsl:element>
        <xsl:element name="RuleAction">
          <xsl:value-of select="ec2:ruleAction" />
        </xsl:element>
        <xsl:element name="Egress">
          <xsl:value-of select="ec2:egress" />
        </xsl:element>
        <xsl:element name="CidrBlock">
          <xsl:value-of select="ec2:cidrBlock" />
        </xsl:element>

        <xsl:apply-templates select="ec2:icmpTypeCode" />
        <xsl:apply-templates select="ec2:portRange" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:icmpTypeCode">
    <xsl:element name="Icmp">
      <xsl:element name="Code">
        <xsl:value-of select="ec2:code" />
      </xsl:element>
      <xsl:element name="Type">
        <xsl:value-of select="ec2:type" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:portRange">
    <xsl:element name="PortRange">
      <xsl:apply-templates select="ec2:from"/>
      <xsl:apply-templates select="ec2:to"/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:from">
    <xsl:element name="From">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:to">
    <xsl:element name="To">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>


  <xsl:template match="ec2:associationSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Associations">
        <xsl:element name="NetworkAclAssociationId">
          <xsl:value-of select="ec2:networkAclAssociationId" />
        </xsl:element>
        <xsl:element name="NetworkAclId">
          <xsl:value-of select="ec2:networkAclId" />
        </xsl:element>
        <xsl:element name="SubnetId">
          <xsl:value-of select="ec2:subnetId" />
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
