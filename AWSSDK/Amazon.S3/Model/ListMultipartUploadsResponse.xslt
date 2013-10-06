<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

  <xsl:template match="s3:ListMultipartUploadsResult">
    <ListMultipartUploadsResponse>
      <BucketName>
        <xsl:value-of select="s3:Bucket"/>
      </BucketName>
      <KeyMarker>
        <xsl:value-of select="s3:KeyMarker"/>
      </KeyMarker>
      <UploadIdMarker>
        <xsl:value-of select="s3:UploadIdMarker"/>
      </UploadIdMarker>
      <NextKeyMarker>
        <xsl:value-of select="s3:NextKeyMarker"/>
      </NextKeyMarker>
      <NextUploadIdMarker>
        <xsl:value-of select="s3:NextUploadIdMarker"/>
      </NextUploadIdMarker>
      <MaxUploads>
        <xsl:value-of select="s3:MaxUploads"/>
      </MaxUploads>
      <IsTruncated>
        <xsl:value-of select="s3:IsTruncated"/>
      </IsTruncated>
      <Prefix>
        <xsl:value-of select="s3:Prefix"/>
      </Prefix>
      <Delimiter>
        <xsl:value-of select="s3:Delimiter"/>
      </Delimiter>

      <CommonPrefixes>
      <xsl:apply-templates select="s3:CommonPrefixes"/>
      </CommonPrefixes>
      <MultipartUploads>
      <xsl:apply-templates select="s3:Upload"/>
      </MultipartUploads>
  
  
  </ListMultipartUploadsResponse>
  </xsl:template>

  <xsl:template match="s3:CommonPrefixes">
    <string>
      <xsl:value-of select="./s3:Prefix"/>
    </string>
  </xsl:template>  

  <xsl:template match="s3:Upload">
    <MultipartUpload>
      <Key>
        <xsl:value-of select="s3:Key"/>
      </Key>
      <UploadId>
        <xsl:value-of select="s3:UploadId"/>
      </UploadId>
      <StorageClass>
        <xsl:value-of select="s3:StorageClass"/>
      </StorageClass>
      <Initiated>
        <xsl:value-of select="s3:Initiated"/>
      </Initiated>
      <Owner>
        <xsl:apply-templates select="s3:Owner"/>
      </Owner>
      <Initiator>
        <xsl:apply-templates select="s3:Owner"/>
      </Initiator>
    
  </MultipartUpload>
  </xsl:template>

  <xsl:template match="s3:Owner">    
      <Id>
        <xsl:value-of select="s3:ID"/>
      </Id>
      <DisplayName>
        <xsl:value-of select="s3:DisplayName"/>
      </DisplayName>
  </xsl:template>
</xsl:stylesheet>
