<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeImagesResponse">
    <xsl:element name="DescribeImagesResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeImagesResult">
        <xsl:apply-templates select="ec2:imagesSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:imagesSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Image">
        <xsl:element name="ImageId">
          <xsl:value-of select="ec2:imageId"/>
        </xsl:element>
        <xsl:element name="ImageLocation">
          <xsl:value-of select="ec2:imageLocation"/>
        </xsl:element>
        <xsl:element name="ImageState">
          <xsl:value-of select="ec2:imageState"/>
        </xsl:element>
        <xsl:element name="OwnerId">
          <xsl:value-of select="ec2:imageOwnerId"/>
        </xsl:element>
        <xsl:element name="Visibility">
          <xsl:if test="ec2:isPublic = 'true'">
            <xsl:text>Public</xsl:text>
          </xsl:if>
          <xsl:if test="not(ec2:isPublic = 'true')">
            <xsl:text>Private</xsl:text>
          </xsl:if>
        </xsl:element>
        <xsl:apply-templates select="ec2:productCodes"/>
        <xsl:element name="Architecture">
          <xsl:value-of select="ec2:architecture"/>
        </xsl:element>
        <xsl:element name="ImageType">
          <xsl:value-of select="ec2:imageType"/>
        </xsl:element>
        <xsl:element name="KernelId">
          <xsl:value-of select="ec2:kernelId"/>
        </xsl:element>
        <xsl:element name="RamdiskId">
          <xsl:value-of select="ec2:ramdiskId"/>
        </xsl:element>
        <xsl:element name="Platform">
          <xsl:value-of select="ec2:platform"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:stateReason"/>
        <xsl:element name="ImageOwnerAlias">
          <xsl:value-of select="ec2:imageOwnerAlias"/>
        </xsl:element>
        <xsl:element name="Name">
          <xsl:value-of select="ec2:name"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="RootDeviceType">
          <xsl:value-of select="ec2:rootDeviceType"/>
        </xsl:element>
        <xsl:element name="RootDeviceName">
          <xsl:value-of select="ec2:rootDeviceName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:blockDeviceMapping"/>
        <xsl:element name="Hypervisor">
          <xsl:value-of select="ec2:hypervisor"/>
        </xsl:element>
        <xsl:element name="VirtualizationType">
          <xsl:value-of select="ec2:virtualizationType"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:tagSet" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
  <xsl:template match="ec2:productCodes">
    <!-- output obsolete id-only list until removed from sdk -->
    <xsl:for-each select="ec2:item">
      <xsl:element name="ProductCodeId">
        <xsl:value-of select="ec2:productCode"/>
      </xsl:element>
    </xsl:for-each>
    <!-- this is the preferred output -->
    <xsl:for-each select="ec2:item">
      <xsl:element name="ProductCodes">
        <xsl:element name="ProductCodeId">
          <xsl:value-of select="ec2:productCode"/>
        </xsl:element>
        <xsl:element name="Type">
          <xsl:value-of select="ec2:type"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:stateReason">
    <xsl:element name="StateReason">
      <xsl:element name="Code">
        <xsl:value-of select="ec2:code"/>
      </xsl:element>
      <xsl:element name="Message">
        <xsl:value-of select="ec2:message"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:blockDeviceMapping">
    <xsl:for-each select="ec2:item">
      <xsl:element name="BlockDeviceMapping">
        <xsl:element name="DeviceName">
          <xsl:value-of select="ec2:deviceName"/>
        </xsl:element>
        <xsl:element name="VirtualName">
          <xsl:value-of select="ec2:virtualName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:ebs"/>
        <xsl:apply-templates select="ec2:noDevice"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:ebs">
    <xsl:element name="Ebs">
      <xsl:element name="SnapshotId">
        <xsl:value-of select="ec2:snapshotId"/>
      </xsl:element>
      <!-- if a snapshot is specified, the volumeSize is optional -->
      <xsl:if test="ec2:volumeSize">
        <xsl:element name="VolumeSize">
          <xsl:value-of select="ec2:volumeSize"/>
        </xsl:element>
      </xsl:if>
      <xsl:element name="DeleteOnTermination">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">
          <xsl:text>false</xsl:text>
        </xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
      <xsl:if test="ec2:volumeType">
        <xsl:element name="VolumeType">
          <xsl:value-of select="ec2:volumeType"/>
        </xsl:element>
      </xsl:if>
      <xsl:if test="ec2:iops">
        <xsl:element name="IOPS">
          <xsl:value-of select="ec2:iops"/>
        </xsl:element>
      </xsl:if>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:noDevice">
    <xsl:element name="NoDevice">
      <xsl:value-of select="'true'"/>
    </xsl:element>
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