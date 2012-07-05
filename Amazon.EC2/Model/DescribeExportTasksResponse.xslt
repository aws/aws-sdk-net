<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
      xmlns:ec2="http://ec2.amazonaws.com/doc/2012-06-01/"
      exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:variable name="ns"
      select="'http://ec2.amazonaws.com/doc/2012-06-01/'" />

  <xsl:template match="ec2:DescribeExportTasksResponse">
    <xsl:element name="DescribeExportTasksResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeExportTasksResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:exportTaskSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:exportTaskSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ExportTaskType" namespace="{$ns}">
        <xsl:element name="ExportTaskId" namespace="{$ns}">
          <xsl:value-of select="ec2:exportTaskId" />
        </xsl:element>
        <xsl:element name="Description" namespace="{$ns}">
          <xsl:value-of select="ec2:description" />
        </xsl:element>
        <xsl:element name="State" namespace="{$ns}">
          <xsl:value-of select="ec2:state" />
        </xsl:element>
        <xsl:element name="StatusMessage" namespace="{$ns}">
          <xsl:value-of select="ec2:statusMessage" />
        </xsl:element>
        <xsl:element name="InstanceExportTaskType" namespace="{$ns}">
          <xsl:apply-templates select="ec2:instanceExport"/>
        </xsl:element>
        <xsl:element name="ExportToS3TaskType" namespace="{$ns}">
          <xsl:apply-templates select="ec2:exportToS3"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:instanceExport">
    <xsl:element name="InstanceId" namespace="{$ns}">
      <xsl:value-of select="ec2:instanceId" />
    </xsl:element>
    <xsl:element name="TargetEnvironment" namespace="{$ns}">
      <xsl:value-of select="ec2:targetEnvironment" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:exportToS3">
    <xsl:element name="DiskImageFormat" namespace="{$ns}">
      <xsl:value-of select="ec2:diskImageFormat" />
    </xsl:element>
    <xsl:element name="ContainerFormat" namespace="{$ns}">
      <xsl:value-of select="ec2:containerFormat" />
    </xsl:element>
    <xsl:element name="S3Bucket" namespace="{$ns}">
      <xsl:value-of select="ec2:s3Bucket" />
    </xsl:element>
    <xsl:element name="S3Key" namespace="{$ns}">
      <xsl:value-of select="ec2:s3Key" />
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
