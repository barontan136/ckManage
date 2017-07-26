/*
Navicat MySQL Data Transfer

Source Server         : 192.168.1.6
Source Server Version : 50718
Source Host           : 192.168.1.6:3306
Source Database       : cangku

Target Server Type    : MYSQL
Target Server Version : 50718
File Encoding         : 65001

Date: 2017-07-27 00:35:36
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for ck_admin_users
-- ----------------------------
DROP TABLE IF EXISTS `ck_admin_users`;
CREATE TABLE `ck_admin_users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `reg_mobile` varchar(255) DEFAULT NULL,
  `level` varchar(255) DEFAULT NULL,
  `create_datetime` datetime DEFAULT NULL,
  `updatetime` datetime DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ck_admin_users
-- ----------------------------
INSERT INTO `ck_admin_users` VALUES ('1', '陈林', '123456', '13412312312', '0', '2017-07-22 22:36:13', '2017-07-22 22:36:16');

-- ----------------------------
-- Table structure for ck_buy
-- ----------------------------
DROP TABLE IF EXISTS `ck_buy`;
CREATE TABLE `ck_buy` (
  `buy_id` int(11) NOT NULL AUTO_INCREMENT,
  `goods_id` int(11) DEFAULT NULL,
  `goods_name` varchar(255) DEFAULT NULL,
  `goods_weight` double DEFAULT NULL,
  `add_time` datetime DEFAULT NULL COMMENT '手动填写的入库时间',
  `create_datetime` datetime DEFAULT NULL,
  `operate_user` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`buy_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ck_buy
-- ----------------------------
INSERT INTO `ck_buy` VALUES ('1', '1', '水泥', '100', '2017-07-23 18:50:31', '2017-07-23 18:50:34', '1');
INSERT INTO `ck_buy` VALUES ('2', '2', '石灰', '120', '2017-07-24 22:18:11', '2017-07-24 22:18:14', '2');
INSERT INTO `ck_buy` VALUES ('3', '1', '水泥', '1000', '2017-07-24 22:45:05', '2017-07-24 22:45:07', '系统管理员');
INSERT INTO `ck_buy` VALUES ('4', '2', '石灰', '1000', '2017-07-24 22:53:08', '2017-07-24 22:53:14', '系统管理员');
INSERT INTO `ck_buy` VALUES ('5', '1', '水泥', '1211', '2017-07-24 22:54:38', '2017-07-24 22:54:44', '系统管理员');
INSERT INTO `ck_buy` VALUES ('6', '2', '石灰', '180', '2017-07-24 23:05:38', '2017-07-24 23:05:45', '系统管理员');
INSERT INTO `ck_buy` VALUES ('7', '1', '水泥', '1000', '2017-07-24 23:06:26', '2017-07-24 23:06:29', '系统管理员');
INSERT INTO `ck_buy` VALUES ('8', '2', '石灰', '1000', '2017-07-24 23:08:58', '2017-07-24 23:09:02', '系统管理员');
INSERT INTO `ck_buy` VALUES ('9', '4', '水泥2', '1000', '2017-07-26 15:24:17', '2017-07-26 15:24:21', '系统管理员');
INSERT INTO `ck_buy` VALUES ('10', '5', '石子', '2000', '2017-07-26 16:27:39', '2017-07-26 16:27:48', '系统管理员');
INSERT INTO `ck_buy` VALUES ('11', '5', '石子', '1000', '2017-07-26 16:28:10', '2017-07-26 16:28:15', '系统管理员');

-- ----------------------------
-- Table structure for ck_goods
-- ----------------------------
DROP TABLE IF EXISTS `ck_goods`;
CREATE TABLE `ck_goods` (
  `goods_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `company` varchar(255) DEFAULT NULL,
  `unit_id` int(11) DEFAULT NULL,
  `unit_name` varchar(255) DEFAULT NULL,
  `hold_weight` double DEFAULT '0' COMMENT '持有重量',
  `min_weight` double DEFAULT '0' COMMENT '库存报警阈值',
  `status` int(2) DEFAULT '0' COMMENT '0:正常 1:废弃 2:删除',
  `create_datetime` datetime DEFAULT NULL,
  `update_datetime` datetime DEFAULT NULL,
  PRIMARY KEY (`goods_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ck_goods
-- ----------------------------
INSERT INTO `ck_goods` VALUES ('1', '水泥', '长沙水泥厂', '1', '千克', '2100', '100', '0', '2017-07-22 22:37:03', '2017-07-25 23:39:00');
INSERT INTO `ck_goods` VALUES ('2', '石灰', '宁乡石灰厂', '1', '千克', '2300', '100', '0', '2017-07-22 22:39:25', '2017-07-26 16:00:12');
INSERT INTO `ck_goods` VALUES ('3', '沙子', '长沙沙子厂', '1', '千克', '100', '500', '1', '2017-07-25 22:52:10', '2017-07-26 15:57:44');
INSERT INTO `ck_goods` VALUES ('4', '水泥2', '长沙水泥厂', '1', '千克', '1100', '200', '1', '2017-07-25 22:56:11', '2017-07-26 15:53:29');
INSERT INTO `ck_goods` VALUES ('5', '石子', '长沙石子厂', '1', '千克', '3000', '123', '0', '2017-07-26 16:13:28', '2017-07-26 16:13:28');

-- ----------------------------
-- Table structure for ck_goods_unit
-- ----------------------------
DROP TABLE IF EXISTS `ck_goods_unit`;
CREATE TABLE `ck_goods_unit` (
  `unit_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `short_name` varchar(255) DEFAULT NULL,
  `create_datetime` datetime DEFAULT NULL,
  PRIMARY KEY (`unit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ck_goods_unit
-- ----------------------------
INSERT INTO `ck_goods_unit` VALUES ('1', '千克', 'Kg', '2017-07-22 22:38:11');

-- ----------------------------
-- Table structure for ck_match
-- ----------------------------
DROP TABLE IF EXISTS `ck_match`;
CREATE TABLE `ck_match` (
  `match_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `config` varchar(255) DEFAULT '' COMMENT '代号+比例#代号+比例... ....',
  `status` tinyint(4) DEFAULT NULL COMMENT '0 正常 1撤回',
  `create_datetime` datetime DEFAULT NULL,
  `update_datetime` datetime DEFAULT NULL,
  PRIMARY KEY (`match_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ck_match
-- ----------------------------
INSERT INTO `ck_match` VALUES ('1', 'AE120', '1#水泥#100&2#石灰#500&5#石子#0', '0', '2017-07-22 22:41:48', '2017-07-26 16:13:28');
INSERT INTO `ck_match` VALUES ('2', 'AE800', '1#水泥#100&2#石灰#800&5#石子#0', '0', '2017-07-26 15:19:52', '2017-07-26 16:13:28');

-- ----------------------------
-- Table structure for ck_sold
-- ----------------------------
DROP TABLE IF EXISTS `ck_sold`;
CREATE TABLE `ck_sold` (
  `sold_id` int(11) NOT NULL AUTO_INCREMENT,
  `match_id` int(11) DEFAULT NULL,
  `match_name` varchar(255) DEFAULT NULL,
  `match_weight` double DEFAULT NULL,
  `sold_config` varchar(255) DEFAULT NULL,
  `status` int(4) DEFAULT NULL COMMENT '0:正常 1:撤回',
  `operate_user` varchar(255) DEFAULT NULL,
  `create_datetime` datetime DEFAULT NULL,
  `update_datetime` datetime DEFAULT NULL,
  PRIMARY KEY (`sold_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ck_sold
-- ----------------------------
INSERT INTO `ck_sold` VALUES ('1', '1', 'AE120', '2', '1#水泥#100&2#石灰#500&5#石子#0', '0', '系统管理员', '2017-07-26 16:46:02', '2017-07-26 16:46:05');

-- ----------------------------
-- Table structure for ck_trade_log
-- ----------------------------
DROP TABLE IF EXISTS `ck_trade_log`;
CREATE TABLE `ck_trade_log` (
  `log_id` int(11) NOT NULL AUTO_INCREMENT,
  `goods_id` int(11) DEFAULT NULL,
  `goods_name` varchar(255) DEFAULT NULL,
  `trade_id` int(11) DEFAULT NULL COMMENT '入库/出库ID',
  `trade_type` tinyint(4) DEFAULT '0' COMMENT '0入库 1出库',
  `trade_weight` double DEFAULT NULL,
  `after_weight` double DEFAULT NULL,
  `operate_user` varchar(255) DEFAULT NULL,
  `create_datetime` datetime DEFAULT NULL,
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ck_trade_log
-- ----------------------------
INSERT INTO `ck_trade_log` VALUES ('1', '5', '石子', '5', '0', '2000', '2000', '系统管理员', '2017-07-26 16:27:48');
INSERT INTO `ck_trade_log` VALUES ('2', '5', '石子', '5', '0', '1000', '3000', '系统管理员', '2017-07-26 16:28:16');
