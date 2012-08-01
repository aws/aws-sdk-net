<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:AllocateAddressResponse">
        <xsl:element name="AllocateAddressResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="AllocateAddressResult">
                <xsl:element name="PublicIp">
                    <xsl:value-of select="ec2:publicIp"/>
                </xsl:element>
              <xsl:element name="Domain">
                <xsl:value-of select="ec2:domain"/>
              </xsl:element>
              <xsl:element name="AllocationId">
                <xsl:value-of select="ec2:allocationId"/>
              </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>

