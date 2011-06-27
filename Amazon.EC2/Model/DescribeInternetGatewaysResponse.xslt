<?xml version="1.0" encoding="utf-8" ?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-05-15/'"/>
    <xsl:template match="ec2:DescribeInternetGatewaysResponse">
        <xsl:element name="DescribeInternetGatewaysResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeInternetGatewaysResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:internetGatewaySet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
  
    <xsl:template match="ec2:internetGatewaySet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="InternetGateways" namespace="{$ns}">
              <xsl:element name="InternetGatewayId" namespace="{$ns}">
                  <xsl:value-of select="ec2:internetGatewayId"/>
              </xsl:element>
              <xsl:apply-templates select="ec2:attachmentSet"/>
              <xsl:apply-templates select="ec2:tagSet"/>
            </xsl:element>
          </xsl:for-each>
    </xsl:template>

  <xsl:template match="ec2:attachmentSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Attachments" namespace="{$ns}">
        <xsl:element name="VpcId" namespace="{$ns}">
          <xsl:value-of select="ec2:vpcId"/>
        </xsl:element>
        <xsl:element name="State" namespace="{$ns}">
          <xsl:value-of select="ec2:state"/>
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
