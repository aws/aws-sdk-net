<?xml version="1.0" encoding="utf-8" ?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeInternetGatewaysResponse">
        <xsl:element name="DescribeInternetGatewaysResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeInternetGatewaysResult">
                <xsl:apply-templates select="ec2:internetGatewaySet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
  
    <xsl:template match="ec2:internetGatewaySet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="InternetGateways">
              <xsl:element name="InternetGatewayId">
                  <xsl:value-of select="ec2:internetGatewayId"/>
              </xsl:element>
              <xsl:apply-templates select="ec2:attachmentSet"/>
              <xsl:apply-templates select="ec2:tagSet"/>
            </xsl:element>
          </xsl:for-each>
    </xsl:template>

  <xsl:template match="ec2:attachmentSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Attachments">
        <xsl:element name="VpcId">
          <xsl:value-of select="ec2:vpcId"/>
        </xsl:element>
        <xsl:element name="State">
          <xsl:value-of select="ec2:state"/>
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
