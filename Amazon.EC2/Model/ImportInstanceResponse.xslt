<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:ImportInstanceResponse">
    <xsl:element name="ImportInstanceResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="ImportInstanceResult">

        <xsl:apply-templates select="ec2:conversionTask"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <!-- ConversionTaskType -->
  <xsl:template match="ec2:conversionTask">
    <xsl:element name="ConversionTask">
      <xsl:element name="ConversionTaskId">
        <xsl:value-of select="ec2:conversionTaskId"/>
      </xsl:element>
      <xsl:element name="ExpirationTime">
        <xsl:value-of select="ec2:expirationTime"/>
      </xsl:element>
      <xsl:element name="RequesterId">
        <xsl:value-of select="ec2:requesterId"/>
      </xsl:element>
      <xsl:element name="State">
        <xsl:value-of select="ec2:state"/>
      </xsl:element>
      <xsl:element name="StatusMessage">
        <xsl:value-of select="ec2:statusMessage"/>
      </xsl:element>

      <xsl:apply-templates select="ec2:importVolume"/>
      <xsl:apply-templates select="ec2:importInstance"/>

    </xsl:element>
  </xsl:template>
    
  <!-- ImportVolumeTaskDetailsType -->
  <xsl:template match="ec2:importVolume">
    <xsl:element name="ImportVolumeRequest">

      <xsl:element name="BytesConverted">
        <xsl:value-of select="ec2:bytesConverted"/>
      </xsl:element>
      <xsl:element name="AvailabilityZone">
        <xsl:value-of select="ec2:availabilityZone"/>
      </xsl:element>
      <xsl:element name="Description">
        <xsl:value-of select="ec2:description"/>
      </xsl:element>

      <xsl:apply-templates select="ec2:image"/>
      <xsl:apply-templates select="ec2:volume"/>
      
    </xsl:element>
  </xsl:template>
  
  <!-- ImportInstanceTaskDetailsType -->
  <xsl:template match="ec2:importInstance">
    <xsl:element name="ImportInstanceRequest">

      <xsl:element name="InstanceId">
        <xsl:value-of select="ec2:instanceId"/>
      </xsl:element>
      <xsl:element name="Platform">
        <xsl:value-of select="ec2:platform"/>
      </xsl:element>
      <xsl:element name="Description">
        <xsl:value-of select="ec2:description"/>
      </xsl:element>

      <xsl:apply-templates select="ec2:volumes"/>
    </xsl:element>
  </xsl:template>
  

  <!-- ImportInstanceVolumeDetailItemType -->
  <xsl:template match="ec2:volumes">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Volumes">

        <xsl:element name="BytesConverted">
          <xsl:value-of select="ec2:bytesConverted"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="StatusMessage">
          <xsl:value-of select="ec2:statusMessage"/>
        </xsl:element>

        <xsl:apply-templates select="ec2:image"/>
        <xsl:apply-templates select="ec2:volume"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <!-- DiskImageDescriptionType -->
  <xsl:template match="ec2:image">
    <xsl:element name="Image">
      <xsl:element name="Format">
        <xsl:value-of select="ec2:format"/>
      </xsl:element>
      <xsl:element name="Size">
        <xsl:value-of select="ec2:size"/>
      </xsl:element>
      <xsl:element name="ImportManifestUrl">
        <xsl:value-of select="ec2:importManifestUrl"/>
      </xsl:element>
      <xsl:element name="Checksum">
        <xsl:value-of select="ec2:checksum"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <!-- DiskImageVolumeDescriptionType -->
  <xsl:template match="ec2:volume">
    <xsl:element name="Volume">
      <xsl:element name="Id">
        <xsl:value-of select="ec2:id"/>
      </xsl:element>
      <xsl:element name="Size">
        <xsl:value-of select="ec2:size"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
