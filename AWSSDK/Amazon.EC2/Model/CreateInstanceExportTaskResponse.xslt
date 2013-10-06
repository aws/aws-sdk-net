<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
      xmlns:ec2="default-ec2-namespace"
      exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  
  <xsl:template match="ec2:CreateInstanceExportTaskResponse">
    <xsl:element name="CreateInstanceExportTaskResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="CreateInstanceExportTaskResult">
          <xsl:element name="ExportTaskType">
            <xsl:apply-templates select="ec2:exportTask"/>
          </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:exportTask">
    <xsl:element name="ExportTaskId">
      <xsl:value-of select="ec2:exportTaskId" />
    </xsl:element>
    <xsl:element name="Description">
      <xsl:value-of select="ec2:description" />
    </xsl:element>
    <xsl:element name="State">
      <xsl:value-of select="ec2:state" />
    </xsl:element>
    <xsl:element name="StatusMessage">
      <xsl:value-of select="ec2:statusMessage" />
    </xsl:element>
    <xsl:element name="InstanceExportTaskType">
      <xsl:apply-templates select="ec2:instanceExport"/>
    </xsl:element>
    <xsl:element name="ExportToS3TaskType">
      <xsl:apply-templates select="ec2:exportToS3"/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:instanceExport">
    <xsl:element name="InstanceId">
      <xsl:value-of select="ec2:instanceId" />
    </xsl:element>
    <xsl:element name="TargetEnvironment">
      <xsl:value-of select="ec2:targetEnvironment" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:exportToS3">
    <xsl:element name="DiskImageFormat">
      <xsl:value-of select="ec2:diskImageFormat" />
    </xsl:element>
    <xsl:element name="ContainerFormat">
      <xsl:value-of select="ec2:containerFormat" />
    </xsl:element>
    <xsl:element name="S3Bucket">
      <xsl:value-of select="ec2:s3Bucket" />
    </xsl:element>
    <xsl:element name="S3Key">
      <xsl:value-of select="ec2:s3Key" />
    </xsl:element>
  </xsl:template>
  
</xsl:stylesheet>
