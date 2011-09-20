
package org.bn.mq.protocol;
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

import org.bn.*;
import org.bn.annotations.*;
import org.bn.annotations.constraints.*;
import org.bn.coders.*;
import org.bn.types.*;




    @ASN1Sequence ( name = "UnsubscriptionMessage", isSet = false )
    public class UnsubscriptionMessage {
            
    @ASN1String( name = "", 
        stringType = UniversalTag.UTF8String , isUCS = false )
    
        @ASN1Element ( name = "consumerId", isOptional =  false , hasTag =  false  , hasDefaultValue =  false  )
    
	private String consumerId = null;
                
  
    @ASN1String( name = "", 
        stringType = UniversalTag.UTF8String , isUCS = false )
    
        @ASN1Element ( name = "queuePath", isOptional =  true , hasTag =  false  , hasDefaultValue =  false  )
    
	private String queuePath = null;
                
  
        
        public String getConsumerId () {
            return this.consumerId;
        }

        

        public void setConsumerId (String value) {
            this.consumerId = value;
        }
        
  
        
        public String getQueuePath () {
            return this.queuePath;
        }

        
        public boolean isQueuePathPresent () {
            return this.queuePath == null;
        }
        

        public void setQueuePath (String value) {
            this.queuePath = value;
        }
        
  
                    
        
        
        public void initWithDefaults() {
            
        }
            
    }
            