<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-05-15/'"/>
  <xsl:template match="ec2:ImportInstanceResponse">
    <xsl:element name="ImportInstanceResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="ImportInstanceResult" namespace="{$ns}">

        <xsl:apply-templates select="ec2:conversionTask"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <!-- ConversionTaskType -->
  <xsl:template match="ec2:conversionTask">
    <xsl:element name="ConversionTask" namespace="{$ns}">
      <xsl:element name="ConversionTaskId" namespace="{$ns}">
        <xsl:value-of select="ec2:conversionTaskId"/>
      </xsl:element>
      <xsl:element name="ExpirationTime" namespace="{$ns}">
        <xsl:value-of select="ec2:expirationTime"/>
      </xsl:element>
      <xsl:element name="RequesterId" namespace="{$ns}">
        <xsl:value-of select="ec2:requesterId"/>
      </xsl:element>
      <xsl:element name="State" namespace="{$ns}">
        <xsl:value-of select="ec2:state"/>
      </xsl:element>
      <xsl:element name="StatusMessage" namespace="{$ns}">
        <xsl:value-of select="ec2:statusMessage"/>
      </xsl:element>

      <xsl:apply-templates select="ec2:importVolume"/>
      <xsl:apply-templates select="ec2:importInstance"/>

    </xsl:element>
  </xsl:template>
    
  <!-- ImportVolumeTaskDetailsType -->
  <xsl:template match="ec2:importVolume">
    <xsl:element name="ImportVolumeRequest" namespace="{$ns}">

      <xsl:element name="BytesConverted" namespace="{$ns}">
        <xsl:value-of select="ec2:bytesConverted"/>
      </xsl:element>
      <xsl:element name="AvailabilityZone" namespace="{$ns}">
        <xsl:value-of select="ec2:availabilityZone"/>
      </xsl:element>
      <xsl:element name="Description" namespace="{$ns}">
        <xsl:value-of select="ec2:description"/>
      </xsl:element>

      <xsl:apply-templates select="ec2:image"/>
      <xsl:apply-templates select="ec2:volume"/>
      
    </xsl:element>
  </xsl:template>
  
  <!-- ImportInstanceTaskDetailsType -->
  <xsl:template match="ec2:importInstance">
    <xsl:element name="ImportInstanceRequest" namespace="{$ns}">

      <xsl:element name="InstanceId" namespace="{$ns}">
        <xsl:value-of select="ec2:instanceId"/>
      </xsl:element>
      <xsl:element name="Platform" namespace="{$ns}">
        <xsl:value-of select="ec2:platform"/>
      </xsl:element>
      <xsl:element name="Description" namespace="{$ns}">
        <xsl:value-of select="ec2:description"/>
      </xsl:element>

      <xsl:apply-templates select="ec2:volumes"/>
    </xsl:element>
  </xsl:template>
  

  <!-- ImportInstanceVolumeDetailItemType -->
  <xsl:template match="ec2:volumes">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Volumes" namespace="{$ns}">

        <xsl:element name="BytesConverted" namespace="{$ns}">
          <xsl:value-of select="ec2:bytesConverted"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone" namespace="{$ns}">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:element name="Description" namespace="{$ns}">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="Status" namespace="{$ns}">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="StatusMessage" namespace="{$ns}">
          <xsl:value-of select="ec2:statusMessage"/>
        </xsl:element>

        <xsl:apply-templates select="ec2:image"/>
        <xsl:apply-templates select="ec2:volume"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <!-- DiskImageDescriptionType -->
  <xsl:template match="ec2:image">
    <xsl:element name="Image" namespace="{$ns}">
      <xsl:element name="Format" namespace="{$ns}">
        <xsl:value-of select="ec2:format"/>
      </xsl:element>
      <xsl:element name="Size" namespace="{$ns}">
        <xsl:value-of select="ec2:size"/>
      </xsl:element>
      <xsl:element name="ImportManifestUrl" namespace="{$ns}">
        <xsl:value-of select="ec2:importManifestUrl"/>
      </xsl:element>
      <xsl:element name="Checksum" namespace="{$ns}">
        <xsl:value-of select="ec2:checksum"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <!-- DiskImageVolumeDescriptionType -->
  <xsl:template match="ec2:volume">
    <xsl:element name="Volume" namespace="{$ns}">
      <xsl:element name="Id" namespace="{$ns}">
        <xsl:value-of select="ec2:id"/>
      </xsl:element>
      <xsl:element name="Size" namespace="{$ns}">
        <xsl:value-of select="ec2:size"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
