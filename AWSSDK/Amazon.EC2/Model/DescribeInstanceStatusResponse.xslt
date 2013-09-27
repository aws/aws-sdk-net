<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:ec2="default-ec2-namespace"
                exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>

  <xsl:template match="ec2:DescribeInstanceStatusResponse">
    <xsl:element name="DescribeInstanceStatusResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeInstanceStatusResult">
        <xsl:apply-templates select="ec2:instanceStatusSet"/>
        <xsl:element name="NextToken">
          <xsl:value-of select="ec2:nextToken"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:instanceStatusSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="InstanceStatus">
        <xsl:element name="InstanceId">
          <xsl:value-of select="ec2:instanceId"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:eventsSet" />
        <xsl:apply-templates select="ec2:instanceState"/>
        <xsl:apply-templates select="ec2:systemStatus" />
        <xsl:apply-templates select="ec2:instanceStatus" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:eventsSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="InstanceStatusEvent">
        <xsl:element name="Code">
          <xsl:value-of select="ec2:code"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="NotBefore">
          <xsl:value-of select="ec2:notBefore"/>
        </xsl:element>
        <xsl:element name="NotAfter">
          <xsl:value-of select="ec2:notAfter"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:instanceState">
    <xsl:element name="InstanceState">
      <xsl:element name="Code">
        <xsl:value-of select="ec2:code"/>
      </xsl:element>
      <xsl:element name="Name">
        <xsl:value-of select="ec2:name"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:systemStatus">
    <xsl:element name="SystemStatusDetail">
      <xsl:element name="Status">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:details" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:instanceStatus">
    <xsl:element name="InstanceStatusDetail">
      <xsl:element name="Status">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:details" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:details">
    <xsl:for-each select="ec2:item">
      <xsl:element name="InstanceStatusDetailType">
        <xsl:element name="Name">
          <xsl:value-of select="ec2:name"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="ImpairedSince">
          <xsl:value-of select="ec2:impairedSince"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>  
  
</xsl:stylesheet>

