<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeLicensesResponse">
        <xsl:element name="DescribeLicensesResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeLicensesResult">
                <xsl:apply-templates select="ec2:licenseSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
	<xsl:template match="ec2:licenseSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="License">
                <xsl:element name="LicenseId">
                    <xsl:value-of select="ec2:licenseId"/>
                </xsl:element>
                <xsl:element name="Type">
                    <xsl:value-of select="ec2:type"/>
                </xsl:element>
                <xsl:element name="Pool">
                    <xsl:value-of select="ec2:pool"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:capacitySet"/>
                <xsl:apply-templates select="ec2:tagSet" />
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="ec2:capacitySet">
    	<xsl:for-each select="ec2:item">
    		<xsl:element name="LicenseCapacity">
    			<xsl:element name="Capacity">
                    <xsl:value-of select="ec2:capacity"/>
                </xsl:element>
    			<xsl:element name="InstanceCapacity">
                    <xsl:value-of select="ec2:instanceCapacity"/>
                </xsl:element>
    			<xsl:element name="State">
                    <xsl:value-of select="ec2:state"/>
                </xsl:element>
    			<xsl:element name="EarliestAllowedDeactivationTime">
                    <xsl:value-of select="ec2:earliestAllowedDeactivationTime"/>
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