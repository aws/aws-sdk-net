<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>

  <xsl:template match="ec2:DescribeNetworkInterfacesResponse">
    <xsl:element name="DescribeNetworkInterfacesResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeNetworkInterfacesResult">
        <xsl:apply-templates select="ec2:networkInterfaceSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:networkInterfaceSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="NetworkInterface">
        <xsl:element name="NetworkInterfaceId">
          <xsl:value-of select="ec2:networkInterfaceId"/>
        </xsl:element>
        <xsl:element name="SubnetId">
          <xsl:value-of select="ec2:subnetId"/>
        </xsl:element>
        <xsl:element name="VpcId">
          <xsl:value-of select="ec2:vpcId"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="OwnerId">
          <xsl:value-of select="ec2:ownerId"/>
        </xsl:element>
        <xsl:element name="RequesterId">
          <xsl:value-of select="ec2:requesterId"/>
        </xsl:element>
        <xsl:element name="RequesterManaged">
          <xsl:value-of select="ec2:requesterManaged"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="MacAddress">
          <xsl:value-of select="ec2:macAddress"/>
        </xsl:element>
        <xsl:element name="PrivateIpAddress">
          <xsl:value-of select="ec2:privateIpAddress"/>
        </xsl:element>
        <xsl:element name="PrivateDnsName">
          <xsl:value-of select="ec2:privateDnsName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:sourceDestCheck"/>
        <xsl:apply-templates select="ec2:groupSet"/>
        <xsl:apply-templates select="ec2:attachment"/>
        <xsl:apply-templates select="ec2:association"/>
        <xsl:apply-templates select="ec2:tagSet" />
        <xsl:apply-templates select="ec2:privateIpAddressesSet" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:privateIpAddressesSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="PrivateIpAddresses">
        <xsl:element name="IpAddress">
          <xsl:value-of select="ec2:privateIpAddress"/>
        </xsl:element>
        <xsl:element name="PrivateDnsName">
          <xsl:value-of select="ec2:privateDnsName"/>
        </xsl:element>
        <xsl:element name="Primary">
          <xsl:value-of select="ec2:primary"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:association"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:sourceDestCheck">
    <xsl:element name="SourceDestCheck">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:groupSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="GroupName">
        <xsl:value-of select="ec2:groupName"/>
      </xsl:element>
      <xsl:element name="GroupId">
        <xsl:value-of select="ec2:groupId"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:attachment">
    <xsl:element name="Attachment">
      <xsl:element name="AttachmentId">
        <xsl:value-of select="ec2:attachmentId"/>
      </xsl:element>
      <xsl:element name="InstanceId">
        <xsl:value-of select="ec2:instanceId"/>
      </xsl:element>
      <xsl:element name="InstanceOwnerId">
        <xsl:value-of select="ec2:instanceOwnerId"/>
      </xsl:element>
      <xsl:element name="DeviceIndex">
        <xsl:value-of select="ec2:deviceIndex"/>
      </xsl:element>
      <xsl:element name="Status">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:element name="AttachTime">
        <xsl:value-of select="ec2:attachTime"/>
      </xsl:element>
      <xsl:element name="DeleteOnTermination">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">false</xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:association">
    <xsl:element name="Association">
      <xsl:element name="PublicIp">
        <xsl:value-of select="ec2:publicIp"/>
      </xsl:element>
      <xsl:element name="PublicDnsName">
        <xsl:value-of select="ec2:publicDnsName"/>
      </xsl:element>
      <xsl:element name="IpOwnerId">
        <xsl:value-of select="ec2:ipOwnerId"/>
      </xsl:element>
      <xsl:element name="AllocationId">
        <xsl:value-of select="ec2:allocationId"/>
      </xsl:element>
      <xsl:element name="AssociationId">
        <xsl:value-of select="ec2:associationId"/>
      </xsl:element>
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
