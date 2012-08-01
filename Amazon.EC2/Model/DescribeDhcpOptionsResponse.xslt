<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:DescribeDhcpOptionsResponse">
		<xsl:element name="DescribeDhcpOptionsResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeDhcpOptionsResult">
				<xsl:apply-templates select="ec2:dhcpOptionsSet" />
			</xsl:element>
		</xsl:element>
	</xsl:template>



	<xsl:template match="ec2:dhcpOptionsSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="DhcpOptions">
				<xsl:element name="DhcpOptionsId">
					<xsl:value-of select="ec2:dhcpOptionsId" />
				</xsl:element>

				<xsl:apply-templates select="ec2:dhcpConfigurationSet" />
        <xsl:apply-templates select="ec2:tagSet" />
			</xsl:element>
		</xsl:for-each>
	</xsl:template>


	<xsl:template match="ec2:dhcpConfigurationSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="Configuration">
				<xsl:element name="Key">
					<xsl:value-of select="ec2:key" />
				</xsl:element>
        		<xsl:apply-templates select="ec2:valueSet" />        
			</xsl:element>
		</xsl:for-each>
	</xsl:template>

	<xsl:template match="ec2:valueSet">
		<xsl:for-each select="ec2:item">
			<xsl:element name="Value">
				<xsl:value-of select="ec2:value" />
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
