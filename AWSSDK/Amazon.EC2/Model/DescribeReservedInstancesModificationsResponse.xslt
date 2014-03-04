<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeReservedInstancesModificationsResponse">
    <xsl:element name="DescribeReservedInstancesModificationsResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeReservedInstancesModificationsResult">
        <xsl:apply-templates select="ec2:reservedInstancesModificationsSet"/>
        <xsl:element name="NextToken">
          <xsl:value-of select="ec2:nextToken"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:reservedInstancesModificationsSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ReservedInstancesModifications">
        <xsl:element name="ReservedInstancesModificationId">
          <xsl:value-of select="ec2:reservedInstancesModificationId"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:reservedInstancesSet" />
        <xsl:apply-templates select="ec2:modificationResultSet" />
        <xsl:element name="CreateDate">
          <xsl:value-of select="ec2:createDate"/>
        </xsl:element>
        <xsl:element name="UpdateDate">
          <xsl:value-of select="ec2:updateDate"/>
        </xsl:element>
        <xsl:element name="EffectiveDate">
          <xsl:value-of select="ec2:effectiveDate"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="StatusMessage">
          <xsl:value-of select="ec2:statusMessage"/>
        </xsl:element>
        <xsl:element name="ClientToken">
          <xsl:value-of select="ec2:clientToken"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:reservedInstancesSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ReservedInstancesId">
        <xsl:element name="ReservedInstancesId">
          <xsl:value-of select="ec2:reservedInstancesId"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:modificationResultSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ReservedInstancesModificationResult">
        <xsl:element name="ReservedInstancesId">
          <xsl:value-of select="ec2:reservedInstancesId"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:targetConfiguration" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:targetConfiguration">
    <xsl:element name="ReservedInstancesConfiguration">
      <xsl:element name="AvailabilityZone">
        <xsl:value-of select="ec2:availabilityZone"/>
      </xsl:element>
      <xsl:element name="Platform">
        <xsl:value-of select="ec2:platform"/>
      </xsl:element>
      <xsl:element name="InstanceCount">
        <xsl:value-of select="ec2:instanceCount"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
