# 探险丽丽
一款类马里奥奥德赛的箱庭平台跳跃游戏，玩家控制角色在关卡内跨越障碍抵达终点。

## 技术亮点

- **状态机系统**：使用FSM管理角色20+种状态（奔跑、攀爬、受伤等），配合动画状态机保持状态一致性
- **物理系统**：通过前上下三重射线检测和向量投影，实现精准的悬挂、攀爬和斜坡物理惯性
- **架构设计**：使用单例模式和观察者模式，实现逻辑层与视觉层解耦
- **UI系统**：基于协程实现跨场景异步加载和UI交互动画，提升用户体验


## 操作方式

- WASD：移动
- 空格：跳跃
- 鼠标左键：旋转攻击
- F：冲刺
- Q：下蹲
- G：拿起箱子
- 空中按E：下砸攻击
- 空中鼠标右键：滑翔飞行
- 下蹲状态按空格：后空翻（移动时按反方向+空格也可后空翻）
- 在墙上时按空格：蹬墙跳

## 演示
<div align="center">
  <img width="400" height="224" alt="1 1"
src="https://github.com/user-attachments/assets/db13cb28-37fa-48ab-95a4-e205863c753c" />

  角色的基础移动

  <img width="400" height="224" alt="2"
src="https://github.com/user-attachments/assets/898179ee-dcac-4115-bedd-f35b23cbb180" />

  攻击怪物，拾取金币

  <img width="400" height="224" alt="3"
src="https://github.com/user-attachments/assets/fdfc80cd-54a8-4b5b-85ca-3611eb29a09a" />

  攀爬系统，下砸攻击
