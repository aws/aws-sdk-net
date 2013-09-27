<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
  exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />

  <xsl:template match="ec2:CreateReservedInstancesListingResponse">
    <xsl:element name="CreateReservedInstancesListingResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="CreateReservedInstancesListingResult">
          <xsl:apply-templates select="ec2:reservedInstancesListingsSet" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:reservedInstancesListingsSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ReservedInstancesListings">
        <xsl:element name="ReservedInstancesListingId">
          <xsl:value-of select="ec2:reservedInstancesListingId"/>
        </xsl:element>
        <xsl:element name="ReservedInstancesId">
          <xsl:value-of select="ec2:reservedInstancesId"/>
        </xsl:element>
        <xsl:element name="CreateDate">
          <xsl:value-of select="ec2:createDate"/>
        </xsl:element>
        <xsl:element name="UpdateDate">
          <xsl:value-of select="ec2:updateDate"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="StatusMessage">
          <xsl:value-of select="ec2:statusMessage"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:instanceCounts" />
        <xsl:apply-templates select="ec2:priceSchedules" />
        <xsl:apply-templates select="ec2:tagSet" />
        <xsl:element name="ClientToken">
          <xsl:value-of select="ec2:clientToken"/>
        </xsl:element>
      </xsl:element>      
    </xsl:for-each>    
  </xsl:template>

  <xsl:template match="ec2:instanceCounts">
    <xsl:for-each select="ec2:item">
      <xsl:element name="InstanceCounts">
        <xsl:element name="State">
          <xsl:value-of select="ec2:state" />
        </xsl:element>
        <xsl:element name="InstanceCount">
          <xsl:value-of select="ec2:instanceCount" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:priceSchedules">
    <xsl:for-each select="ec2:item">
      <xsl:element name="PriceSchedules">
        <xsl:element name="Term">
          <xsl:value-of select="ec2:term" />
        </xsl:element>
        <xsl:element name="Price">
          <xsl:value-of select="ec2:price" />
        </xsl:element>
        <xsl:element name="CurrencyCode">
          <xsl:value-of select="ec2:currencyCode" />
        </xsl:element>
        <xsl:element name="Active">
          <xsl:value-of select="ec2:active" />
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
