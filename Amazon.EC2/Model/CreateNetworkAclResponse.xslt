<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/"
	exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2011-05-15/'" />
  <xsl:template match="ec2:CreateNetworkAclResponse">
    <xsl:element name="CreateNetworkAclResponse"
			namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="CreateNetworkAclResult"
				namespace="{$ns}">
        <xsl:apply-templates select="ec2:networkAcl" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:networkAcl">
    <xsl:element name="NetworkAcl" namespace="{$ns}">
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
    </xsl:element>
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

</xsl:stylesheet>