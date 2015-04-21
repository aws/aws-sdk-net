<?xml version="1.0" encoding="utf-8"?>

<!--
XSLT modified from original at http://geekswithblogs.net/gavin/archive/2009/08/25/134311.aspx
-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:vs="http://microsoft.com/schemas/VisualStudio/TeamTest/2010">
  <xsl:template match="/">
    <html>
      <head>
        <style type="text/css">
          input.button {
          color: #fff; background: #0034D0;
          font-size: .8em;
          font-weight:bold;
          font-family: Verdana, Arial, Helvetica, sans-serif;
          border: solid 1px #ffcf31;
          }
        </style>
        <script language="JavaScript">
          function toggleMe(a)
          {
          var e=document.getElementById(a);
          if(!e)return true;
          if(e.style.display=="none"){
          e.style.display="block"
          } else {
          e.style.display="none"
          }
          return true;
          }
        </script>
      </head>
      <body style="font-family:Verdana; font-size:10pt">
        <h1>Test Results Summary</h1>
        <table style="width:100%;border:1px solid black;font-family:Verdana; font-size:10pt;">
          <tr>
            <td width="150">
              <b>Start Date/Time</b>
            </td>
            <td width="550">
              <xsl:value-of select="//vs:Times/@start"/>
            </td>
          </tr>
          <tr>
            <td width="150">
              <b>End Date/Time</b>
            </td>
            <td width="550">
              <xsl:value-of select="//vs:Times/@finish"/>
            </td>
          </tr>
          <tr>
            <td width="150">
              <b>Total Time</b>
            </td>
            <td width="550">
              <xsl:value-of select="//vs:Results/vs:TestResultAggregation/@duration"/>
            </td>
          </tr>
          <tr>
            <td width="150">
              <b>Results</b>
            </td>
            <td width="550">
              <xsl:value-of select="//vs:TestRun/@name"/>
            </td>
          </tr>
        </table>
        <xsl:call-template name="summary" />
        <xsl:call-template name="details" />
      </body>
    </html>
  </xsl:template>
  <xsl:template name="summary">
    <h3>Test Summary</h3>
    <table style="width:100%;border:1px solid black;font-family:Verdana; font-size:10pt">
      <tr>
        <td style="font-weight:bold">Total</td>
        <td style="font-weight:bold">Failed</td>
        <td style="font-weight:bold">Passed</td>
      </tr>
      <tr>
        <td >
          <xsl:value-of select="//vs:ResultSummary/vs:Counters/@total"/>
        </td>
        <td style="background-color:pink;">
          <xsl:value-of select="//vs:ResultSummary/vs:Counters/@failed"/>
        </td>
        <td style="background-color:lightgreen;">
          <xsl:value-of select="//vs:ResultSummary/vs:Counters/@passed"/>
        </td>
      </tr>
    </table>
  </xsl:template>
  <xsl:template name="details">
    <h3>Test Details</h3>
    <table style="width:100%;border:1px solid black;font-family:Verdana; font-size:10pt;">
      <tr>
        <td style="font-weight:bold">Test Name</td>
        <td style="font-weight:bold">Result</td>
        <td style="font-weight:bold">Duration</td>
        <td style="font-weight:bold">Details</td>
      </tr>
      <!-- UnitTestResult -->
      <xsl:for-each select="//vs:Results/vs:UnitTestResult">
        <xsl:variable name="executionId">
          <xsl:value-of select="@executionId"/>
        </xsl:variable>
        <tr>
          <xsl:attribute name="style">
            <xsl:choose>
              <xsl:when test="@outcome = 'Failed'">background-color:pink;</xsl:when>
              <xsl:when test="@outcome = 'Passed'">background-color:lightgreen;</xsl:when>
              <xsl:otherwise>background-color:yellow;</xsl:otherwise>
            </xsl:choose>
          </xsl:attribute>
          <td>
            <xsl:value-of select="@testName"/>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="@outcome = 'Failed'">FAILED</xsl:when>
              <xsl:when test="@outcome = 'Passed'">Passed</xsl:when>
              <xsl:otherwise>Inconclusive</xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:value-of select="@duration"/>
          </td>
          <td>
            <xsl:if test="vs:Output">
              <input type="button" class="button" onclick="return toggleMe('{$executionId}')" value="Details" align="right" />
            </xsl:if>
          </td>
        </tr>
        <tr>
          <td colspan="4">
            <div style="display:none" id="{$executionId}">
              <table style="width:100%;border:1px solid black;font-family:Verdana; font-size:10pt;">
                <tr>
                  <td colspan="4">
                    <!--<xsl:for-each select="vs:InnerResults/vs:GenericTestResult">-->
                    <xsl:if test="vs:Output">
                      <table style="width:100%;border:1px solid black;font-family:Verdana;font-size:8pt;table-layout:fixed;">
                        <tr>
                          <td width="10"></td>
                          <td>
                            <b>
                              <xsl:value-of select="@testName"/>
                            </b>
                          </td>
                        </tr>
                        <tr>
                          <td width="10"></td>
                          <td>
                            <pre style="word-wrap: break-word">
                              <xsl:value-of select="vs:Output/vs:StdOut"/>
                            </pre>
                          </td>
                        </tr>
                        <xsl:if test="vs:Output/vs:ErrorInfo">
                          <tr>
                            <td width="10"></td>
                            <td>
                              <span>Error Message</span>
                              <pre style="word-wrap: break-word">
                                <xsl:value-of select="vs:Output/vs:ErrorInfo/vs:Message"/>
                              </pre>
                            </td>
                          </tr>
                          <tr>
                            <td width="10"></td>
                            <td>
                              <span>Error StackTrace</span>
                              <pre style="word-wrap: break-word">
                                <xsl:value-of select="vs:Output/vs:ErrorInfo/vs:StackTrace"/>
                              </pre>
                            </td>
                          </tr>
                        </xsl:if>
                      </table>
                    <!--</xsl:for-each>-->
                    </xsl:if>
                  </td>
                </tr>
              </table>
            </div>
          </td>
        </tr>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>