<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeAddressesResponse">
        <xsl:element name="DescribeAddressesResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeAddressesResult">
                <xsl:apply-templates select="ec2:addressesSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:addressesSet">
        <xsl:apply-templates select="ec2:item"/>
    </xsl:template>
    <xsl:template match="ec2:item">
        <xsl:element name="Address">
            <xsl:element name="InstanceId">
                <xsl:value-of select="ec2:instanceId"/>
            </xsl:element>
            <xsl:element name="PublicIp">
                <xsl:value-of select="ec2:publicIp"/>
            </xsl:element>
          <xsl:element name="AllocationId">
            <xsl:value-of select="ec2:allocationId"/>
          </xsl:element>
          <xsl:element name="AssociationId">
            <xsl:value-of select="ec2:associationId"/>
          </xsl:element>
          <xsl:element name="Domain">
            <xsl:value-of select="ec2:domain"/>
          </xsl:element>
          <xsl:element name="NetworkInterfaceId">
            <xsl:value-of select="ec2:networkInterfaceId"/>
          </xsl:element>
          <xsl:element name="NetworkInterfaceOwnerId">
            <xsl:value-of select="ec2:networkInterfaceOwnerId"/>
          </xsl:element>
          <xsl:element name="PrivateIpAddress">
            <xsl:value-of select="ec2:privateIpAddress"/>
          </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
