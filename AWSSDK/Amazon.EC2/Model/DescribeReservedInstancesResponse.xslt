<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeReservedInstancesResponse">
        <xsl:element name="DescribeReservedInstancesResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeReservedInstancesResult">
                <xsl:apply-templates select="ec2:reservedInstancesSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:reservedInstancesSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="ReservedInstances">
                <xsl:element name="ReservedInstancesId">
                    <xsl:value-of select="ec2:reservedInstancesId"/>
                </xsl:element>
                <xsl:element name="InstanceType">
                    <xsl:value-of select="ec2:instanceType"/>
                </xsl:element>
                <xsl:element name="AvailabilityZone">
                    <xsl:value-of select="ec2:availabilityZone"/>
                </xsl:element>
                <xsl:element name="Duration">
                    <xsl:value-of select="ec2:duration"/>
                </xsl:element>
                <xsl:element name="UsagePrice">
                    <xsl:value-of select="ec2:usagePrice"/>
                </xsl:element>
                <xsl:element name="FixedPrice">
                    <xsl:value-of select="ec2:fixedPrice"/>
                </xsl:element>
                <xsl:element name="InstanceCount">
                    <xsl:value-of select="ec2:instanceCount"/>
                </xsl:element>
                <xsl:element name="ProductDescription">
                    <xsl:value-of select="ec2:productDescription"/>
                </xsl:element>
                <xsl:element name="PurchaseState">
                    <xsl:value-of select="ec2:state"/>
                </xsl:element>
                <xsl:element name="StartTime">
                    <xsl:value-of select="ec2:start"/>
                </xsl:element>
                <xsl:element name="InstanceTenancy">
                  <xsl:value-of select="ec2:instanceTenancy"/>
                </xsl:element>
                <xsl:element name="CurrencyCode">
                  <xsl:value-of select="ec2:currencyCode"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:tagSet" />

                <xsl:element name="OfferingType">
                  <xsl:value-of select="ec2:offeringType"/>
                </xsl:element>

                <xsl:apply-templates select="ec2:recurringCharges"/>
              
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

  <xsl:template match="ec2:recurringCharges">
    <xsl:for-each select="ec2:item">
      <xsl:element name="RecurringCharges">
        <xsl:element name="Frequency">
          <xsl:value-of select="ec2:frequency"/>
        </xsl:element>
        <xsl:element name="Amount">
          <xsl:value-of select="ec2:amount"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
