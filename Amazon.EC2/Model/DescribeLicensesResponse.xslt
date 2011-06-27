<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-05-15/'"/>
    <xsl:template match="ec2:DescribeLicensesResponse">
        <xsl:element name="DescribeLicensesResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeLicensesResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:licenseSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
	<xsl:template match="ec2:licenseSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="License" namespace="{$ns}">
                <xsl:element name="LicenseId" namespace="{$ns}">
                    <xsl:value-of select="ec2:licenseId"/>
                </xsl:element>
                <xsl:element name="Type" namespace="{$ns}">
                    <xsl:value-of select="ec2:type"/>
                </xsl:element>
                <xsl:element name="Pool" namespace="{$ns}">
                    <xsl:value-of select="ec2:pool"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:capacitySet"/>
                <xsl:apply-templates select="ec2:tagSet" />
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="ec2:capacitySet">
    	<xsl:for-each select="ec2:item">
    		<xsl:element name="LicenseCapacity" namespace="{$ns}">
    			<xsl:element name="Capacity" namespace="{$ns}">
                    <xsl:value-of select="ec2:capacity"/>
                </xsl:element>
    			<xsl:element name="InstanceCapacity" namespace="{$ns}">
                    <xsl:value-of select="ec2:instanceCapacity"/>
                </xsl:element>
    			<xsl:element name="State" namespace="{$ns}">
                    <xsl:value-of select="ec2:state"/>
                </xsl:element>
    			<xsl:element name="EarliestAllowedDeactivationTime" namespace="{$ns}">
                    <xsl:value-of select="ec2:earliestAllowedDeactivationTime"/>
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