<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-05-15/'"/>
  <xsl:template match="ec2:DescribeNetworkAclsResponse">
    <xsl:element name="DescribeNetworkAclsResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeNetworkAclsResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:networkAclSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="ec2:networkAclSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="NetworkAcls" namespace="{$ns}">
        <xsl:element name="NetworkAclId" namespace="{$ns}">
          <xsl:value-of select="ec2:networkAclId" />
        </xsl:element>
        <xsl:element name="VpcId" namespace="{$ns}">
          <xsl:value-of select="ec2:vpcId" />
        </xsl:element>
        <xsl:element name="Default" namespace="{$ns}">
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
      <xsl:element name="Entries" namespace="{$ns}">
        <xsl:element name="RuleNumber" namespace="{$ns}">
          <xsl:value-of select="ec2:ruleNumber" />
        </xsl:element>
        <xsl:element name="Protocol" namespace="{$ns}">
          <xsl:value-of select="ec2:protocol" />
        </xsl:element>
        <xsl:element name="RuleAction" namespace="{$ns}">
          <xsl:value-of select="ec2:ruleAction" />
        </xsl:element>
        <xsl:element name="Egress" namespace="{$ns}">
          <xsl:value-of select="ec2:egress" />
        </xsl:element>
        <xsl:element name="CidrBlock" namespace="{$ns}">
          <xsl:value-of select="ec2:cidrBlock" />
        </xsl:element>

        <xsl:apply-templates select="ec2:icmpTypeCode" />
        <xsl:apply-templates select="ec2:portRange" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:icmpTypeCode">
    <xsl:element name="Icmp" namespace="{$ns}">
      <xsl:element name="Code" namespace="{$ns}">
        <xsl:value-of select="ec2:code" />
      </xsl:element>
      <xsl:element name="Type" namespace="{$ns}">
        <xsl:value-of select="ec2:type" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:portRange">
    <xsl:element name="PortRange" namespace="{$ns}">
      <xsl:apply-templates select="ec2:from"/>
      <xsl:apply-templates select="ec2:to"/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:from">
    <xsl:element name="From" namespace="{$ns}">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:to">
    <xsl:element name="To" namespace="{$ns}">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>


  <xsl:template match="ec2:associationSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Associations" namespace="{$ns}">
        <xsl:element name="NetworkAclAssociationId" namespace="{$ns}">
          <xsl:value-of select="ec2:networkAclAssociationId" />
        </xsl:element>
        <xsl:element name="NetworkAclId" namespace="{$ns}">
          <xsl:value-of select="ec2:networkAclId" />
        </xsl:element>
        <xsl:element name="SubnetId" namespace="{$ns}">
          <xsl:value-of select="ec2:subnetId" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag" namespace="{$ns}">
        <xsl:element name="Key" namespace="{$ns}">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value" namespace="{$ns}">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
</xsl:stylesheet>
