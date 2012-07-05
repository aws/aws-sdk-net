<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2012-06-01/" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2012-06-01/'"/>

  <xsl:template match="ec2:CreateNetworkInterfaceResponse">
    <xsl:element name="CreateNetworkInterfaceResponse"
			namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="CreateNetworkInterfaceResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:networkInterface" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:networkInterface">
    <xsl:element name="NetworkInterface" namespace="{$ns}">
      <xsl:element name="NetworkInterfaceId" namespace="{$ns}">
        <xsl:value-of select="ec2:networkInterfaceId"/>
      </xsl:element>
      <xsl:element name="SubnetId" namespace="{$ns}">
        <xsl:value-of select="ec2:subnetId"/>
      </xsl:element>
      <xsl:element name="VpcId" namespace="{$ns}">
        <xsl:value-of select="ec2:vpcId"/>
      </xsl:element>
      <xsl:element name="AvailabilityZone" namespace="{$ns}">
        <xsl:value-of select="ec2:availabilityZone"/>
      </xsl:element>
      <xsl:element name="Description" namespace="{$ns}">
        <xsl:value-of select="ec2:description"/>
      </xsl:element>
      <xsl:element name="OwnerId" namespace="{$ns}">
        <xsl:value-of select="ec2:ownerId"/>
      </xsl:element>
      <xsl:element name="RequesterId" namespace="{$ns}">
        <xsl:value-of select="ec2:requesterId"/>
      </xsl:element>
      <xsl:element name="RequesterManaged" namespace="{$ns}">
        <xsl:value-of select="ec2:requesterManaged"/>
      </xsl:element>
      <xsl:element name="Status" namespace="{$ns}">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:element name="MacAddress" namespace="{$ns}">
        <xsl:value-of select="ec2:macAddress"/>
      </xsl:element>
      <xsl:element name="PrivateIpAddress" namespace="{$ns}">
        <xsl:value-of select="ec2:privateIpAddress"/>
      </xsl:element>
      <xsl:element name="PrivateDnsName" namespace="{$ns}">
        <xsl:value-of select="ec2:privateDnsName"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:sourceDestCheck"/>

      <xsl:apply-templates select="ec2:groupSet"/>
      <xsl:apply-templates select="ec2:attachment"/>
      <xsl:apply-templates select="ec2:association"/>
      <xsl:apply-templates select="ec2:tagSet" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:sourceDestCheck">
    <xsl:element name="SourceDestCheck" namespace="{$ns}">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:groupSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="GroupName" namespace="{$ns}">
        <xsl:value-of select="ec2:groupName"/>
      </xsl:element>
      <xsl:element name="GroupId" namespace="{$ns}">
        <xsl:value-of select="ec2:groupId"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:attachment">
    <xsl:element name="Attachment" namespace="{$ns}">
      <xsl:element name="AttachmentId" namespace="{$ns}">
        <xsl:value-of select="ec2:attachmentId"/>
      </xsl:element>
      <xsl:element name="InstanceId" namespace="{$ns}">
        <xsl:value-of select="ec2:instanceId"/>
      </xsl:element>
      <xsl:element name="InstanceOwnerId" namespace="{$ns}">
        <xsl:value-of select="ec2:instanceOwnerId"/>
      </xsl:element>
      <xsl:element name="DeviceIndex" namespace="{$ns}">
        <xsl:value-of select="ec2:deviceIndex"/>
      </xsl:element>
      <xsl:element name="Status" namespace="{$ns}">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:element name="AttachTime" namespace="{$ns}">
        <xsl:value-of select="ec2:attachTime"/>
      </xsl:element>
      <xsl:element name="DeleteOnTermination" namespace="{$ns}">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">false</xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:association">
    <xsl:element name="Association" namespace="{$ns}">
      <xsl:element name="PublicIp" namespace="{$ns}">
        <xsl:value-of select="ec2:publicIp"/>
      </xsl:element>
      <xsl:element name="IpOwnerId" namespace="{$ns}">
        <xsl:value-of select="ec2:ipOwnerId"/>
      </xsl:element>
      <xsl:element name="AllocationId" namespace="{$ns}">
        <xsl:value-of select="ec2:allocationId"/>
      </xsl:element>
      <xsl:element name="AssociationId" namespace="{$ns}">
        <xsl:value-of select="ec2:associationId"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag" namespace="{$ns}">
        <xsl:element name="Key" namespace="{$ns}">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value" namespace="{$ns}">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
